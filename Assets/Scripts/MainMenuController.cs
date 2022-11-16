using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    static public void ExitGame()
    {
        print("Called yea");
        Application.Quit();
    }
}
