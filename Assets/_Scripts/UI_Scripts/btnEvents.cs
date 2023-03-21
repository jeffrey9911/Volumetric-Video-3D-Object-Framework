using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class btnEvents : MonoBehaviour
{
    public GameObject _scanPanel;
    public GameObject _soarPanel;

    public void TestClickEvent()
    {
        Debug.Log("TEST-Button-OnCLICK!");
    }

    public void ScanOnClick()
    {
        _scanPanel.SetActive(true);
        _soarPanel.SetActive(false);
    }

    public void SoarOnClick()
    {
        _scanPanel.SetActive(false);
        _soarPanel.SetActive(true);
    }
}
