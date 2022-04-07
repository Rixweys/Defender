using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeraldOfDeath : MonoBehaviour
{
    public float speed = -3f;
    private Animator anim;
    private int once = 1;
    private int twice = 0;
    private int health = 10;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0f, 0f));

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Fireball>())
        {
            twice++;
            health--;
            CheckOfHealth();
            twice--;
        }
        else if (collision.gameObject.GetComponent<Wall>())
        {
            speed = 0f;
            StartCoroutine(Idle());
            StartCoroutine(Hit());

        }
    }

    public void GoldDrop()
    {
        Gold.GoldForKill();
    }

    void KillEnemy()
    {
        Destroy(gameObject);
    }

    IEnumerator Death()
    {
        once--;
        anim.SetBool("State_idle", false);
        anim.SetInteger("State_death", 1);
        yield return null;
    }

    IEnumerator Idle()
    {
        if (once == 1)
            anim.SetBool("State_idle", true);
        yield return null;
    }

    IEnumerator GetDamage()
    {
        once--;
        anim.SetBool("State_idle", false);
        speed = 1.5f;
        anim.SetInteger("State_get_damage", 1);
        yield return new WaitForSeconds(0.1f);
        speed = -3f;
        anim.SetInteger("State_get_damage", 2);
        once++;
    }

    IEnumerator Hit()
    {
        CheckOfHealth();
        yield return new WaitForSeconds(2f);
        anim.SetBool("State_hit", true);
        CheckOfHealth();
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("State_hit", false);
        CheckOfHealth();
        StartCoroutine(Hit());
    }

    private void CheckOfHealth()
    {
        if (twice == 1)
        {
            if (health == 0)
            {
                speed = 0;
                GoldDrop();
                StartCoroutine(Death());
                Invoke("KillEnemy", 0.36f);
            }
            else
                StartCoroutine(GetDamage());
        }

    }
}
