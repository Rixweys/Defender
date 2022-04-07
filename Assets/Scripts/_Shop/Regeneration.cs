using UnityEngine;
using UnityEngine.UI;

public class Regeneration : MonoBehaviour
{
    public Sprite[] Bar;
    [SerializeField]
    private Image image;

    private void Update()
    {
        image.sprite = Bar[RegenerationButton.upgrade];
    }
}
