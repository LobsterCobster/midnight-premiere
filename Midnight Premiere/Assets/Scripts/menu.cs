using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject loadingscreen;
    public GameObject helpmenu; // added this trying to get Help working
    public string sceneName, sceneName2;
    public Button helpButton; // added this trying to get Help working

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    public void playGame()
    {
        loadingscreen.SetActive(true);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }
    
    public void helpMenu() // added this trying to get Help working
    {
        helpmenu.SetActive(true);
    }
    
    public void backToMainMenu() // added this trying to get Help working
    {
        helpmenu.SetActive(false);
    }
    
    public void quitGame()
    {
        Debug.Log("This will quit the game, only works in actual build, not in Unity editor.");
        Application.Quit();
    }

    public void youtubeChannel()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    }
}