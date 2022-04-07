using UnityEngine;
using UnityEngine.UI;

public class Kills : MonoBehaviour
{
    [SerializeField]
    private Text killsText;
    public static int kills;
    void Update()
    {
        killsText.text = "Kills: " + kills.ToString();
    }
    public static void KillForKill()
    {
        kills++;
    }
}
