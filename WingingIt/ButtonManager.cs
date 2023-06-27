using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void OptionsButton()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void CreditsButton()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void HomeButton()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {
        Debug.Log("The user has quit the game");
        Application.Quit();
    }
}
