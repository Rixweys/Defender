using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Slime;
    public GameObject Boss;
    private readonly float spawnrate = 5f;
    void Start()
    {
        StartCoroutine(SpawnSlime());
        StartCoroutine(SpawnBoss());
    }
    IEnumerator SpawnSlime()
    {
        Instantiate(Slime, new Vector2(11f, Random.Range(-4.5f, 2.5f)), Quaternion.identity);
        yield return new WaitForSeconds(spawnrate);
        StartCoroutine(SpawnSlime());
    }
    IEnumerator SpawnBoss()
    {
        yield return new WaitForSeconds(60f);
        Instantiate(Boss, new Vector2(11f, Random.Range(-4.5f, 2.5f)), Quaternion.identity);
    }
}
