using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    public static int maxHealth = 50;
    public static int health;

    private void Start()
    {
        health = maxHealth;
        StartCoroutine(Regen());
    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Slime>())
            health -= 1;
    }
    IEnumerator Regen()
    {
        while (true)
        {
            if (health < maxHealth)
                health++;
            yield return new WaitForSeconds(15f - RegenerationButton.regenUp);
        }
    }
}
