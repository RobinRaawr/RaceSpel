using UnityEngine;
using System.Collections;

public class FlyingMotor2 : MonoBehaviour
{
    public float speed = 20;

    void Start()
    {

    }
    void FixedUpdate()
    {
        // Rotating the object while turning
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, 0, 60 * Time.deltaTime);
            Debug.Log(Input.GetAxis("Horizontal").ToString());
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log(Input.GetAxis("Horizontal").ToString());
            transform.Rotate(0, 0, -60 * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.identity;
            
        }

        // Up and down probably

        if (Input.GetAxis("Vertical") < 0)
            transform.Rotate(-60 * Time.deltaTime, 0, 0);
        else if (Input.GetAxis("Vertical") > 0)
            transform.Rotate(60 * Time.deltaTime, 0, 0);

        // Flying forward
        transform.Translate(0, 0, speed * Time.deltaTime);

    }
}
