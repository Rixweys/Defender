using UnityEngine;
using UnityEngine.UI;

public class FireRate : MonoBehaviour
{
    public Sprite[] Bar;
    [SerializeField]
    private Image image;

    private void Update()
    {
        image.sprite = Bar[FireRateButton.upgrade];
    }
}
