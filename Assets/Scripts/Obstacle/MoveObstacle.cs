using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void FixedUpdate()
    {
        
    }

    void Update()
    {
        
    }
}
