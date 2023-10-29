using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displayinfo : MonoBehaviour
{
    //public GameObject SkeletonPanel;
    //public GameObject MascularPanel;
    public GameObject Panel;

    private bool isPanelActive;
    void Start()
    {
        isPanelActive = false;
        setPanelState();
    }

    public void ChangePaneState()
    {
        isPanelActive = !isPanelActive;
        setPanelState();
    }
    private void setPanelState()
    {
        Panel.SetActive(isPanelActive);
    }
}
