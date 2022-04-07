using UnityEngine.UI;
using UnityEngine;

public class DamageButton : MonoBehaviour
{
    public Text healthText;
    public static byte upgrade = 0;
    public int price = 50;
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
            price = (int)(price * 1.2f);
        }
    }
}
