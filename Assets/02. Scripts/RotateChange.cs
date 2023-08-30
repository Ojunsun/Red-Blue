using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChange : MonoBehaviour
{
    [SerializeField] int angle = 180;
    [SerializeField] bool turnLeft = true;

    private void FixedUpdate()
    {
        rotateChange();
    }

    private void rotateChange()
    {
        if (turnLeft == false)
        {
            this.transform.Rotate(0, 0, -angle / (angle / 2));
        }
        else
        {
            this.transform.Rotate(0, 0, angle / (angle / 2));
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
