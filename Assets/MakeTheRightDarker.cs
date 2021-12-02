using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class MakeTheRightDarker : MonoBehaviour
{
    private Light2D rightLight;

    private void Start()
    {
        rightLight = GameObject.Find("rightLightX").GetComponent<Light2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "MakeThemDarker")
        {
            rightLight.intensity = 0f;
        }

    }
}