using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void OnClickStart()
    {
        Wall.WallHealth = 5;
        Gold.gold = 0;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}

