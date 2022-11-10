using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    
    void Update()
    {
        //Grab the mesh renderer so that Color can be accessed
        MeshRenderer objectRenderer = gameObject.GetComponent<MeshRenderer>();

        //Access the health variable in the Target script of this gameobject
        float health = gameObject.GetComponent<Target>().health;

        //Create an orange color, had to make a new one since Orange is not a color that Unity provides
        Color normalHealth = new Color(0.9528301f, 0.379043f, 0.1662958f, 1f); //orange


        //Change the color of the mesh renderer based on the amount of Health
        if (health <= 10)
        {
            objectRenderer.material.color = Color.red;
            objectRenderer.material.EnableKeyword("_EMISSION");
            objectRenderer.material.SetColor("_EmissionColor", Color.red);
        }
        else if (health >= 11 && health <= 50)
        {
            objectRenderer.material.color = normalHealth;
        }
        else if (health >= 51 && health <= 100)
        {
            objectRenderer.material.color = Color.yellow;
        }
    }
}
