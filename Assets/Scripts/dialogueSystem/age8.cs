using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class age8 : MonoBehaviour
{
    public GameObject Age8;
    public GameObject Age8caught;
    public GameObject principalOffice;
    public void continueButton()
    {
        Age8.SetActive(false);
    }
    public void caughtButton()
    {
        Age8.SetActive(false);
        Age8caught.SetActive(true);
    }
    public void principalContinue()
    {
        principalOffice.SetActive(false);
    }
}
