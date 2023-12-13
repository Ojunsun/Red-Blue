using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] bool colorBlue = true;
    public List<GameObject> red = new List<GameObject>();
    public List<GameObject> blue = new List<GameObject>();


    public void changeColor()
    {
        if (colorBlue == true )
        {   
            for (int i = 0; i < red.Count; i++)
            {
                blue[i].SetActive(true);
                red[i].SetActive(false);
            }
            colorBlue = false;
        }
        else if(colorBlue == false )
        {
            for (int i = 0; i < blue.Count; i++)
            {
                blue[i].SetActive(false);
                red[i].SetActive(true);
            }
            colorBlue = true;
        }
    }

    public void ColorBool()
    {
        if (colorBlue == false)
        {
            colorBlue = true;
        }
        else
        {
            colorBlue = false;
        }
    }
}
