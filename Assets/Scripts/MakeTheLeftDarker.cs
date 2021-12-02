using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class MakeTheLeftDarker : MonoBehaviour
{
    private Light2D leftLight;
    private Light2D rightLight;
    private bool lightConditionX;

    private void Start()
    {
        leftLight = GameObject.Find("leftLightX").GetComponent<Light2D>();
        rightLight = GameObject.Find("rightLightX").GetComponent<Light2D>();
        lightConditionX = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (lightConditionX == true && collider.tag == "playafollowa")
        {
            StartCoroutine(WaitAndDarkness());

        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        


        


    }

    IEnumerator WaitAndDarkness()
    {
        rightLight.intensity = 0;
        yield return new WaitForSeconds(0.001f);
        leftLight.intensity = 0;
    }
}
