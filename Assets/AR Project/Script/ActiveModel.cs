using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveModel : MonoBehaviour
{
    public GameObject System1, System2;

    public void Start()
    {
        System1.SetActive(true);
        System2.SetActive(false);
    }
    public void btnSystem1Show()
    {
        System1.SetActive(true);
        System2.SetActive(false);
    }
    public void btnSystem2Show()
    {
        System1.SetActive(false);
        System2.SetActive(true);
    }
}
