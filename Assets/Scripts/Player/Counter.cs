using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    
    public int score;
    

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "counter")
        {
            score++;
        }
    }

    void Update()
    {
        scoreText.text = score.ToString();
        
        
    }

    

}
