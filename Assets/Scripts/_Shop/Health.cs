using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Sprite[] Bar;
    [SerializeField]
    private Image image;

    private void Update()
    {
        image.sprite = Bar[HealthButton.upgrade];
    }
}
