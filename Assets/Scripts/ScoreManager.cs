using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreDisplay;

    public static ScoreManager Instance;

    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = score.ToString();
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int value) 
    {
        score += value;

        scoreDisplay.text = score.ToString();
    
   
    }


}
