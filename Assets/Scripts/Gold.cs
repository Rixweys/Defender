using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    [SerializeField]
    private Text goldText;
    public static int gold;
    void Update()
    {
        goldText.text = "Gold: " + gold.ToString();
    }
    public static void GoldForKill() 
    {
        gold += Random.Range(1, 3);
    }
}
