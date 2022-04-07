using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    private readonly float spawnrate = 0.5f;
    void Start()
    {
        StartCoroutine(InsObj());
    }
    IEnumerator InsObj()
    {
        while (true)
        {
            Instantiate(obj, new Vector2(11f, Random.Range(-4.5f, 3.2f)), Quaternion.identity);
            yield return new WaitForSeconds(spawnrate);
        }
    }
}
