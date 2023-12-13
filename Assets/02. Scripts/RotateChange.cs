using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateChange : MonoBehaviour
{
    [SerializeField] int angle = 180;
    [SerializeField] bool turnLeft = true;
    [SerializeField] GameObject Right_Img;
    [SerializeField] GameObject Left_Img;

    private void FixedUpdate()
    {
        rotateChange();
    }

    private void rotateChange()
    {
        if (turnLeft == false)
        {
            this.transform.Rotate(0, 0, -angle / (angle / 2));
            Left_Img.SetActive(true);
            Right_Img.SetActive(false);
        }
        else
        {
            this.transform.Rotate(0, 0, angle / (angle / 2));
            Right_Img.SetActive(true);
            Left_Img.SetActive(false);
        }
    }

    public void RotateBool()
    {
        if(turnLeft == false)
        {
            turnLeft = true;
        }
        else
        {
            turnLeft = false;
        }
    }
}
