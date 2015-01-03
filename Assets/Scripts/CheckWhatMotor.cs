using UnityEngine;
using System.Collections;

public class CheckWhatMotor : MonoBehaviour
{
    public HoverMotor hoverMotor;
    public FlyingMotor2 flyingMotor;

    public bool switched;
    
    void Update()
    {
        // Dit moet niet in de update.. maar waar wel! 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switched = !switched;
        }

        if (switched) // Flying mode
        {
            hoverMotor.enabled = false;
            flyingMotor.enabled = true;

            rigidbody.useGravity = false;
            renderer.material.color = Color.red;
        }

        if (!switched) // Hover mode
        {
            hoverMotor.enabled = true;
            flyingMotor.enabled = false;

            rigidbody.useGravity = true;
            //rigidbody.freezeRotation = false;
            renderer.material.color = Color.blue;
        }

    }
}
