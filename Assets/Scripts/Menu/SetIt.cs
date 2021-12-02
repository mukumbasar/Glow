using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetIt : MonoBehaviour
{
    public TextMeshProUGUI currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore.text = TransferData.scoreData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
