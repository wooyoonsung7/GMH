using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class page : MonoBehaviour
{
    public GameObject[] Page = new GameObject[0];
   
    public void OnButtonClick1()
    {
        Page[1].SetActive(true); Page[0].SetActive(false);
    }
    public void OnButtonClick2()
    {
        Page[2].SetActive(true); Page[1].SetActive(false);
    }
    public void OnButtonClick3()
    {
        Page[3].SetActive(true); Page[2].SetActive(false);
    }
    public void OnButtonClick4()
    {
        Page[4].SetActive(true); Page[3].SetActive(false);
    }
    public void OnButtonClick5()
    {
        Page[5].SetActive(true); Page[4].SetActive(false);
    }
    public void OnButtonClick6()
    {
        Page[6].SetActive(true); Page[5].SetActive(false);
    }
    public void OnButtonClick7()
    {
        Page[7].SetActive(true); Page[6].SetActive(false);
    }
    public void OnButtonClick8()
    {
        Page[0].SetActive(true); Page[7].SetActive(false);
    }
}
