using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //SceneManager.LoadScene(1);
        // ^ Loading Scene by Build Index ^
        //SceneManager.LoadScene("BoatTest");
        SceneManager.LoadScene("OpenOcean");
        // ^ Loading Scene by Scene Name (String. Prefered?) ^
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // ^ Loading Scene by Order ^
    }
    //^ NTS: This is a Method that here says when Play Game is selected, thenn the main game scene is opened ^
    //^ To Do: Do the same with other menu options ^
    //^ Also: I should probably save this as a template ^
    public void QuitGame()
    {
        Application.Quit();
    }
    //^ This is a Method that says when the game is Quit(ted?) for realz (you're welcome), then close the game ^
    //^ Also: I should probably save this as a template ^
}
