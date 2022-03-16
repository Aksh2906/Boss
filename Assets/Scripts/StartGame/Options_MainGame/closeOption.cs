using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeOption : MonoBehaviour
{
    public GameObject mainGame;
    public GameObject assetPanel;
    public GameObject jobPanel;
    public GameObject shopPanel;
    public GameObject eduPanel;
    public void disableAsset()
    {
        assetPanel.SetActive(false);
        mainGame.SetActive(true);
    }
    public void disableJob()
    {
        jobPanel.SetActive(false);
        mainGame.SetActive(true);
    }
    public void disableShop()
    {
        shopPanel.SetActive(false);
        mainGame.SetActive(true);
    }
    public void disableEdu()
    {
        eduPanel.SetActive(false);
        mainGame.SetActive(true);
    }

}
