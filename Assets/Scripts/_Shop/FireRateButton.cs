using UnityEngine;
using UnityEngine.UI;


public class FireRateButton : MonoBehaviour
{
    public Text healthText;
    public static byte upgrade = 0;
    public int price = 100;
    public static float firerateUp = 0f;
    void Update()
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
            price = (int)(price * 1.5f);
            firerateUp += 0.05f;
        }
    }
}
