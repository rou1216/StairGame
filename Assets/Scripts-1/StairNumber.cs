using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StairNumber : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Stairs"))
        {
            Destroy(other.gameObject);
            UpdateScore(1);
        }
    }
   
        
    
    public void UpdateScore(int S){
        score += S;
        scoreText.text = "Score: "+score;
    }
}
