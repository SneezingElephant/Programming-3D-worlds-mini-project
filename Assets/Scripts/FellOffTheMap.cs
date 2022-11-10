using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FellOffTheMap : MonoBehaviour
{
    //Destroy the game object if they fall off the map
    void Update()
    {
        if (gameObject.transform.position.y < -50f)
        {
            Destroy(gameObject);
        }
    }
}
