using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SampleScoreScript : MonoBehaviour
{

    public int score;

    public TextMeshProUGUI ScoreText;

    private void Update()
    {
        ScoreText.text = "Score: " + score;
    }
}
