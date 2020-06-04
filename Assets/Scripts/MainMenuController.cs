using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject OptionMenu;

    public void playGame()
    {
        SceneManager.LoadScene("Main");
    }
   
    public void options ()
    {
        mainMenu.SetActive(false);
        OptionMenu.SetActive(true);
    }
    public void back ()
    {
        mainMenu.SetActive(true);
        OptionMenu.SetActive(false);
    }
    public void punten()
    {

    }
    public void exitGame()
    {
        Application.Quit();
    }
}
