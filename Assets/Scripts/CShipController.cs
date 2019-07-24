using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipController : MonoBehaviour
{

    Rigidbody rigidbody;

    public float shipSpeed = 10f;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * shipSpeed * Time.smoothDeltaTime);

        float h = Input.GetAxisRaw("horizontal");


    }

    void FixedUpdate()
    {
        
    }
}
