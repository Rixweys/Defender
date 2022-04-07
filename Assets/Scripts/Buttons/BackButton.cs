using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
