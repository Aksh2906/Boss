using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openOption : MonoBehaviour
{
    public GameObject mainGame;
    public GameObject assetPanel;
    public GameObject jobPanel;
    public GameObject shopPanel;
    public GameObject eduPanel;
    public void enableAsset()
    {
        mainGame.SetActive(false);
        assetPanel.SetActive(true);
    }
    public void enableJob()
    {
        mainGame.SetActive(false);
        jobPanel.SetActive(true);
    }
    public void enableShop()
    {
        mainGame.SetActive(false);
        shopPanel.SetActive(true);
    }
    public void enableEdu()
    {
        mainGame.SetActive(false);
        eduPanel.SetActive(true);
    }
    

}
