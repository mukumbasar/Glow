using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destroya"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            TransferData.scoreData = score.text;
        }

    }

}
