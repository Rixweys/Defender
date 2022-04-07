using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject Pause_menu;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
                Resume();
            else
                Pause();
        }
    }
    public void Resume() 
    {
        Pause_menu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pause() 
    {
        Pause_menu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void  Return() 
    {
        Time.timeScale = 1f;
        GameIsPause = false;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
