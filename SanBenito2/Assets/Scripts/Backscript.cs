using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Backscript : MonoBehaviour
{

    public Button backButton;

    public void goback()
    {
        SceneManager.LoadScene("Mainmenu");
    }
   
}
