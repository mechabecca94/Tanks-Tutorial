using UnityEngine;

public class rotate : MonoBehaviour
{
    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
      //  transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up/2 * Time.deltaTime, Space.World);
    }
}