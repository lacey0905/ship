using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipController : MonoBehaviour
{



    Rigidbody rigidbody;

    public float shipSpeed = 10f;
    public float shipTurnSpeed = 100f;

    public float angle = 0f;

    public CShipRotate rotate;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
    }

    void Update()
    {
        //transform.Translate(Vector3.forward * shipSpeed * Time.smoothDeltaTime);

        float h = Input.GetAxisRaw("Horizontal");


        if (h != 0)
        {
            angle += Time.deltaTime * h * shipTurnSpeed;
            
            if(angle > 360f)
            {
                angle = 0f;
            }
            Vector3 rot = new Vector3(0f, angle, 0f);

            rotate.transform.localEulerAngles = rot;

        }
        else
        {
            angle = 0f;
        }
        



        //if (h != 0)
        //{
        //    transform.Rotate(Vector3.up * Time.deltaTime * h * shipTurnSpeed);
        //    rot = this.transform.forward;
        //}
        //else
        //{
        //    //Quaternion newRot = Quaternion.LookRotation(rot);

        //    ship.transform.rotation = Quaternion.LookRotation(rot);

        //    transform.rotation = ship.transform.rotation;
        //}






    }

    


    void FixedUpdate()
    {
        
    }
}
