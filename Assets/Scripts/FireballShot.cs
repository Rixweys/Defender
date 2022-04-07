using System.Timers;
using UnityEngine;
using System.Collections;

public class FireballShot : MonoBehaviour
{
    public float offset = -90;
    public GameObject FireballObj;
    public Transform FireballShotPoint;
    
    public static float TimeBtwShots;
    [SerializeField]
    private float Firerate = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        if (OptionMenu.GameIsPause == false)
        {
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

            if (TimeBtwShots <= 0)
            {
                if (Input.GetMouseButton(0))
                {
                    StartCoroutine(Hero.Attack());
                    StartCoroutine(FireballShoot());
                    TimeBtwShots = Firerate + 1f - FireRateButton.firerateUp;
                }
            }
            else
                TimeBtwShots -= Time.deltaTime;
               
        }
    }
    IEnumerator FireballShoot()
    {
        yield return new WaitForSeconds(0.7f);
        Instantiate(FireballObj, FireballShotPoint.position, transform.rotation);

    }
    
}
