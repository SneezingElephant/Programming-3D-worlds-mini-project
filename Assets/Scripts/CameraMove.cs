using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform cameraPosition;
    //make the camera always move to the position of the CameraPos empty object (child of Player object)
    void Update()
    {

        transform.position = new Vector3(cameraPosition.position.x, cameraPosition.position.y, cameraPosition.position.z);

    }
}
