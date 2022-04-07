using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Sprite[] Bar;
    [SerializeField]
    private Image image;

    private void Update()
    {
        image.sprite = Bar[DamageButton.upgrade];
    }
}
