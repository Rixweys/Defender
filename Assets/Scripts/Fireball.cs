using System.Collections;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField]
    private float speed = 25f;
    [SerializeField]
    private float lifetime = 1.5f;

    void Start()
    {
        StartCoroutine(InsObj());
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Slime>() || collision.gameObject.GetComponent<HeraldOfDeath>())
            Destroy(gameObject);
    }
    
    IEnumerator InsObj()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
