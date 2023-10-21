using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float forwardSpeed = 200f;

    [SerializeField]
    private float sideWaysSpeed = 500f;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0f, 0f, forwardSpeed * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideWaysSpeed * Time.deltaTime, 0f, 0f);
        }

        if(Input.GetKey("a")) 
        {
            rb.AddForce((sideWaysSpeed * -1) * Time.deltaTime, 0f, 0f);
        }
    }
}
