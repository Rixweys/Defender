using UnityEngine;
using UnityEngine.UI;


public class StonksButton : MonoBehaviour
{
    public Text healthText;
    public static byte upgrade = 0;
    public int price = 150;
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
            price = (int)(price * 1.8f);
        }
    }
}
