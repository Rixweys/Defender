using UnityEngine;
using UnityEngine.UI;

public class Stonks : MonoBehaviour
{
    public Sprite[] Bar;
    [SerializeField]
    private Image image;

    private void Update()
    {
        image.sprite = Bar[StonksButton.upgrade];
    }
}
