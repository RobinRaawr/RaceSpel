using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject car;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position;
    }

    // Camera movement, procedual animation and gatherin last man states? lateupdate
    void LateUpdate()
    {
        transform.position = car.transform.position + offset;
    }
}
