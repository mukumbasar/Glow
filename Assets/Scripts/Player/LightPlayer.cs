using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class LightPlayer : MonoBehaviour
{

    public Light2D Light;
    private bool lightCondition;
    


    void Start()
    {
        
        Light = GameObject.Find("Playerisik").GetComponent<Light2D>();
        Light.intensity = 0;
        lightCondition = false;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (lightCondition == false && collider.tag == "counter")
        {
            
            StartCoroutine(WaitAndDarkness());

        }

    }

    IEnumerator WaitAndDarkness()
    {
        Light.intensity = 1.46f;
        yield return new WaitForSeconds(0.5f);
        Light.intensity = 0;
    }
}
