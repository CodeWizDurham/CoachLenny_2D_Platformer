using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SampleCollectableScript : MonoBehaviour
{
    public int MyPoints;

    public SampleScoreScript ScoreUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreUI.score += MyPoints;
            Destroy(gameObject);
        }
    }
}
