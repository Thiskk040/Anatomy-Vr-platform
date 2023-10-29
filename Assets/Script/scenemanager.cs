using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public void loadScenePlay()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void loadSceneSetting()
    {
        SceneManager.LoadScene(2);
    }
    public void loadSceneInterface()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            loadSceneSetting();
        }
    }



}
