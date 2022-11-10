using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        MeshRenderer objectRenderer = gameObject.GetComponent<MeshRenderer>();


        float health = gameObject.GetComponent<Target>().health;

        Color normalHealth = new Color(0.9528301f, 0.379043f, 0.1662958f, 1f); //orange

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
