using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        else if (Input.GetKeyDown(KeyCode.R))
            GamePlayUIController.Restart();
        else if (Input.GetKeyDown(KeyCode.H))
            MainMenuController.ExitGame();
    }
}
