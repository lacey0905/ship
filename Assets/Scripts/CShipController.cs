using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipController : MonoBehaviour
{

    Rigidbody rigidbody;

    public float shipSpeed = 10f;
    public float shipTurnSpeed = 100f;

    public Vector3 rot;

    public GameObject ship;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
    }

    private void Update()
    {
        //transform.Translate(Vector3.forward * shipSpeed * Time.smoothDeltaTime);

        float h = Input.GetAxisRaw("Horizontal");


        



        if (h != 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * h * shipTurnSpeed);
            rot = this.transform.forward;
        }
        else
        {
            //Quaternion newRot = Quaternion.LookRotation(rot);

            ship.transform.rotation = Quaternion.LookRotation(rot);

            transform.rotation = ship.transform.rotation;
        }






    }

    


    void FixedUpdate()
    {
        
    }
}
