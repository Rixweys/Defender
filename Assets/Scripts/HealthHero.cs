using UnityEngine;
using UnityEngine.UI;

public class HealthHero : MonoBehaviour
{
    public Text healthText;

    void Update()
    {
        healthText.text = $"Health: {Wall.health}";

    }
}
