using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private static Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public static IEnumerator Attack()
    {
        anim.SetBool("State_hero_attack", true);
        yield return new WaitForSeconds(FireballShot.TimeBtwShots);
        anim.SetBool("State_hero_attack", false);
    }
}
