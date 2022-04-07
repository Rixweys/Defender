using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void OnClickStart() 
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
