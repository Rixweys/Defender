using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    public static int maxHealth = 50;
    public static int WallHealth;

    private void Start()
    {
        WallHealth = maxHealth;
        StartCoroutine(Regen());
    }

    void Update()
    {
        if (WallHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }

    IEnumerator Regen()
    {
        while (true)
        {
            if (WallHealth < maxHealth)
                WallHealth++;
            yield return new WaitForSeconds(15f - RegenerationButton.regenUp);
        }
    }
}
