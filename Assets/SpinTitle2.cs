using UnityEngine;
using System.Collections;

public class SpinTitle2 : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject placeholder;

    void Start()
    {
        rb = placeholder.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(1, 1, 10);
       //     rb.AddForce (5, 1, 1);
    }

    void FixedUpdate()
{
     rb.AddForce(0,20,0);
}
}