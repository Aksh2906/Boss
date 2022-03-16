using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class age8Caught : MonoBehaviour
{
    public GameObject Age8caught;
    public GameObject principalOffice;
    public void continueButton()
    {
        Age8caught.SetActive(false);
    }
    public void argueButton()
    {
        Age8caught.SetActive(false);
        principalOffice.SetActive(true);

    }
}
