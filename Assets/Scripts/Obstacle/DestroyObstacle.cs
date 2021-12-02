using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{


    private void OnTriggerExit2D(Collider2D otherObj)
    {
        if (otherObj.CompareTag("shredder"))
        {
            Destroy(gameObject);

        }


    }
}
