using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public Button newGameButton;

    public Button settingsButton;

    public Button exitGameButton;

    public Button iButton;

    public void Awake()
    {
        newGameButton.onClick.AddListener(NewGame);
        settingsButton.onClick.AddListener(settings);
        exitGameButton.onClick.AddListener(ExitGame);
        iButton.onClick.AddListener(credits);
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Project");
    }

    public void settings()
    {
        SceneManager.LoadScene("settings");
    }

    public void ExitGame()
    {
     
        Application.Quit();
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

}
