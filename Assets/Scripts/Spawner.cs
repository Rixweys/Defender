using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    private readonly float spawnrate = 2f;
    void Start()
    {
        StartCoroutine(InsObj());
    }
    IEnumerator InsObj()
    {
        Instantiate(obj, new Vector2(11f, Random.Range(-4.5f, 3.2f)), Quaternion.identity);
        yield return new WaitForSeconds(spawnrate);
        StartCoroutine(InsObj());
    }
}
