using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class RegenerationButton : MonoBehaviour
{
    public Text healthText;
    public static byte upgrade = 0;
    public int price = 75;
    public static float regenUp = 0f;
    private void Start()
    {

    }
    private void Update()
    {
        healthText.text = $"{price}";
        if (upgrade == 14)
            Destroy(gameObject);
    }

    public void Upgrade()
    {
        if (upgrade < 14 && Gold.gold >= price)
        {
            upgrade++;
            Gold.gold -= price;
            price = (int)(price * 1.3f);
            regenUp += 0.02f;
        }
    }
    
}
