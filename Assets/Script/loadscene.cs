using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public void startSkeletonAr()
    {
        SceneManager.LoadScene(1);
    }
    public void startMascularAr()
    {
        SceneManager.LoadScene(2);
    }
    public void startSkinAr()
    {
        SceneManager.LoadScene(3);
    }
    public void startMaleReproAr()
    {
        SceneManager.LoadScene(4);
    }
    public void startFemaleReproAr()
    {
        SceneManager.LoadScene(5);
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
    public void Backtomain()
    {
        SceneManager.LoadScene(0);
    }
}
