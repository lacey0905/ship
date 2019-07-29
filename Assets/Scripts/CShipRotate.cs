using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipRotate : MonoBehaviour
{


    public void Turn(float _angle)
    {
        transform.localEulerAngles = new Vector3(0, _angle, 0);
    }

    public Vector3 GetFoward()
    {
        return transform.forward;
    }

  
}
