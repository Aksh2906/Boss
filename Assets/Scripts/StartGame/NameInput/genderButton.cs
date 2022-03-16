using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class genderButton : MonoBehaviour
{
    public Text femaleName;
    public string name01female;
    public Text maleName;
    public string name01male;
    
    
    public void changeNamefemale()
    {
        
        
        List<string> names = new List<string>{ "Olivia", "Amelia", "Isabella", "Jessica", "Poppy","Isla","Victoria","Tracy" };
        
        int index = Random.Range(0,names.Count);
        this.name01female=names[index];
    
        femaleName.GetComponent<Text>().text="Recommended Name: "+name01female;
        
    }
    public void changeNamemale()
    {
        
        
        List<string> names = new List<string>{ "Daniel", "Robert", "Sam", "Jason", "Chris","Aaron","Albert","Brian" };
        int index = Random.Range(0,names.Count);
        this.name01male=names[index];
        maleName.GetComponent<Text>().text="Recommended Name: "+name01male;
    }

}
