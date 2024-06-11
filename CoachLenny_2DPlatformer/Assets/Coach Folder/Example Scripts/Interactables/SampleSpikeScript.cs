using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SampleSpikeScript : MonoBehaviour
{
    public SampleHealthScript sampleHealthScript;

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sampleHealthScript.Health -= 1;
        }
    }
}
