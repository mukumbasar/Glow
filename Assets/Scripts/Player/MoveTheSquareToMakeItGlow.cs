using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheSquareToMakeItGlow : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private bool right;
    

    private bool anotherLeft;
    private bool anotherRight;

    void Awake()
    {

        var tempFloat = Random.Range(0, 1);

        
        

        if (tempFloat == 0)
        {
            
            right = false;
        }
        else if (tempFloat == 1);
        {
           
            right = true;
        }

        
        anotherRight = false;
        anotherLeft = false;



    }


    void Update()
    {

        KeepItInBounds();
        MoveIt();

    }

    private void FixedUpdate()
    {
        if(anotherRight)
        {
            rb.velocity = new Vector2(0, 0) * speed * Time.deltaTime;
            rb.velocity = Vector2.right * speed * Time.deltaTime;

            anotherRight = false;
        }

        if(anotherLeft)
        {
            rb.velocity = new Vector2(0, 0) * speed * Time.deltaTime;
            rb.velocity = -Vector2.right * speed * Time.deltaTime;

            anotherLeft = false;
        }
    }
    


    private void KeepItInBounds()
    {
        if (transform.position.x < -3.22)
        {
            transform.position = new Vector3(3.19f, -3f, 0);
        }
        if (transform.position.x > 3.22)
        {
            transform.position = new Vector3(-3.19f, -3f, 0);
        }
    }

    private void MoveIt()
    {
        if (Input.GetKeyDown(KeyCode.Space) && right)
        {
            anotherRight = true;
            
            
            right = false;
            
            

        }

        else if (Input.GetKeyDown(KeyCode.Space) && !right)
        {
            anotherLeft = true;
            
            right = true;
        }
    }


}