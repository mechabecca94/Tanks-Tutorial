using UnityEngine;
using System.Collections;

public class SpinTitle : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject placeholder;

    void Start()
    {
        rb = placeholder.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(1, 1, 10);
       //     rb.AddForce (5, 1, 1);
    }

    void OnCollisionEnter (Collision Collision)
{
     rb.AddForce(2,1,1);
}

/*void OnCollisionEnter(Collision collision)
    {
    				 if (this.gameObject.name == "right"){
    				 rb.Sleep();
    	            rb.AddForce (-100, 20, 20);
    	       }

    	             if (this.gameObject.name == "left"){
    	             	 rb.Sleep();
    	            rb.AddForce (100, 20, 20);
    	       }

    	             if (this.gameObject.name == "up"){
    	             	 rb.Sleep();
    	            rb.AddForce (20, -100, 20);
    	       }

    	             if (this.gameObject.name == "down"){
    	             	 rb.Sleep();
    	            rb.AddForce (20, 100, 20);
   }

    	             if (this.gameObject.name == "back"){
    	             	 rb.Sleep();
    	            rb.AddForce (20, 20, -100);
    	       }

    	             if (this.gameObject.name == "front"){
    	             	 rb.Sleep();
    	            rb.AddForce (100, 20, 100);
    	          } 
    }*/

}