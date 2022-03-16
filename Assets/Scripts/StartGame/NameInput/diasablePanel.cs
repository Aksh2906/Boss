using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diasablePanel : MonoBehaviour
{
    public GameObject mainGame;
    
    public GameObject disableInput;
    public Text Input;
    public Text nameFinal;
    public GameObject errorText;
    
    
    public void updatePanel()
    {
        disableInput.SetActive(false);
        mainGame.SetActive(true);
        if(Input!=null)
        {
            string name=Input.GetComponent<Text>().text;
            this.nameFinal.GetComponent<Text>().text=name;
        }
        else if(Input==null)
        {
            errorText.SetActive(true);
        }

    }
    
}
