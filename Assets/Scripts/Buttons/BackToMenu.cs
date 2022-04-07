using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void OnClickStart()
    {
        Wall.health = 5;
        Gold.gold = 0;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}

