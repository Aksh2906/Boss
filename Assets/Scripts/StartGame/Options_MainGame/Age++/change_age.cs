using UnityEngine;
using UnityEngine.UI;

public class change_age : MonoBehaviour
{
    public GameObject age, Age6, Age7, Age8;
    
    string friendName= "Robie";
    public Text age07, age08;
    
    public int defaultAge= 5;
    string number;
    public void AddAge()
    {
        this.defaultAge++;
        this.number=defaultAge.ToString();
        age.GetComponent<Text>().text=this.number;
        if (this.defaultAge==6)
        {
            Age6.SetActive(true);
        }
        else if(this.defaultAge==7)
        {
            age07.GetComponent<Text>().text=friendName+" wants to become your friend";
            Age7.SetActive(true);
        }
        else if(this.defaultAge==8)
        {
            age08.GetComponent<Text>().text="Steal "+friendName+" notebook.";
            Age8.SetActive(true);
        }
    }
}
