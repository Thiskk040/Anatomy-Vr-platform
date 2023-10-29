using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_manager : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnSettingButton()
    {
        SceneManager.LoadScene(2);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
   
}
