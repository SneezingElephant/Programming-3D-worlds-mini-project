using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    
    //Assign parameters for the gun
    public float damage = 10f;
    public float range = 100f;

    //Assign an FPS camera that will be used to aim
    public Camera fpsCam;
    private void Update()
    {
        //Assign hotkey for firing the weapon
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        //Choose the point where the raycast will be shot from, in this case the front of the FPS cam variable
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Display the name of the target that the raycast hits for debugging purposes
            Debug.Log(hit.transform.name);
            
            //Acess the target script
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                //Give damage based on the damage variable to every gameobject that is hit and has the Target script attached
                target.TakeDamage(damage);
            }
        }


    }
}
