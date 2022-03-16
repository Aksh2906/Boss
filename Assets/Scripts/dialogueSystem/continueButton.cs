using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueButton : MonoBehaviour
{
    public change_age age;
    public GameObject Age6, Age7, Age8, Age8caught, principalOffice;
    public void Button()
    {
        if(age.defaultAge == 6)
        {
            Age6.SetActive(false);
        }
        if(age.defaultAge == 7)
        {
            Age7.SetActive(false);
        }
        if(age.defaultAge == 8)
        {
            Age8.SetActive(false);
        }
    }

}
