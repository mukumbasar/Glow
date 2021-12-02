using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollower : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D followarb;
    void Start()
    {
        followarb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        followarb.MovePosition(player.transform.position);
    }
}
