using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; // Note: We need this to use Convert

/*
    Bitwise Operators:
    & (AND)
    | (OR)
    ^ (XOR)
    ! (NOT)
    |= OR + (Setting)
    &= ~X (Unsetting)
*/

public class AttributeManager : MonoBehaviour
{
    static public int MAGIC = 16;
    static public int INTELLIGENCE = 8;
    static public int CHARISMA = 4;
    static public int FLY = 2;
    static public int INVISIBLE = 1;

    public Text attributeDisplay;
    int attributes = 0;

    void OnTriggerEnter(Collider other) 
    {
        // Turning bit flags 'ON'
        if (other.gameObject.tag == "MAGIC")
        {
            attributes |= MAGIC;
        }
        else if (other.gameObject.tag == "INTELLIGENCE")
        {
            attributes |= INTELLIGENCE;
        }
        else if (other.gameObject.tag == "CHARISMA")
        {
            attributes |= CHARISMA;
        }
        else if (other.gameObject.tag == "FLY")
        {
            attributes |= FLY;
        }
        else if (other.gameObject.tag == "INVISIBLE")
        {
            attributes |= INVISIBLE;
        }

        // Turning bit flags 'OFF'
        else if (other.gameObject.tag == "ANTIMAGIC")
        {
            attributes &= ~MAGIC;
        }

        // Turning multiple bit flags 'ON'
        else if (other.gameObject.tag == "MAGICANDINTELLIGENCE")
        {
            attributes |= MAGIC | INTELLIGENCE;
        }
        // Turning multiple bit flags 'OFF'
        else if (other.gameObject.tag == "ANTIMAGICANDINTELLIGENCE")
        {
            attributes &= ~(MAGIC | INTELLIGENCE);
        }
        // Remove All
        else if (other.gameObject.tag == "REMOVEALL")
        {
            attributes = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
    }
       
}
