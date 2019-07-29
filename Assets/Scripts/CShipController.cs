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
        rotate = rotate.GetComponent<CShipRotate>();
    }

    void Start()
    {
    }


    public Vector3 turn;


    Quaternion newRot;

    void Update()
    {
        //transform.Translate(Vector3.forward * shipSpeed * Time.smoothDeltaTime);

        float h = Input.GetAxisRaw("Horizontal");


        if (h != 0)
        {
            angle += h * Time.deltaTime * shipTurnSpeed;

            Vector3 direction = transform.forward;

            Quaternion q = Quaternion.Euler(0f, angle, 0f);
            Vector3 newDirection = q * direction;

            turn = newDirection;

            rotate.transform.forward = turn;

        }
        else
        {
            angle = 0f;
            rotate.transform.forward = transform.forward;

            newRot = Quaternion.LookRotation(turn);

        }
        if (rigidbody.rotation != newRot)
        {
            rigidbody.rotation = Quaternion.Slerp(rigidbody.rotation, newRot, 2f * Time.deltaTime);
        }

    }

    


    void FixedUpdate()
    {
        
    }
}
