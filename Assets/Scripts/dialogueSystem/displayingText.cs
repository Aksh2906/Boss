using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayingText : MonoBehaviour
{
    public Text[] inputText;
    public Text outputText;
    public change_age age;
    string storeText;
    
    void Start()
    {
        
                        
    }

    
    void Update()
    {
        if (age.defaultAge == 6)
        {
            this.storeText = inputText[0].GetComponent<Text>().text + "/n";
            outputText.GetComponent<Text>().text = storeText;  
        }

    }
}
