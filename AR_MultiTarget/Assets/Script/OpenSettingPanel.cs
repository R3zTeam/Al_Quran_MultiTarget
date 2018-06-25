using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettingPanel : MonoBehaviour
{
    public GameObject PanelMenu;
    public bool panelMenuActive;

    // Use this for initialization
    public void OpenPanelMenu()
    {
        PanelMenu.SetActive(true);
    }
    public void ClosePanelMenu()
    {
        PanelMenu.SetActive(false);
    }
}