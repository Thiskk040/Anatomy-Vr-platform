using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setting : MonoBehaviour
{
   public void OnRestartButton()
   {
        SceneManager.LoadScene(1);
   }
    public void OnExitMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
