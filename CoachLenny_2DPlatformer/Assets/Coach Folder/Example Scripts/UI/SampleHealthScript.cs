using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SampleHealthScript : MonoBehaviour
{
    public Image[] heatlhImage;

    public int Health;

    private void Update()
    {
        
        if(Health == 3)
        {
            heatlhImage[0].gameObject.SetActive(true);
            heatlhImage[1].gameObject.SetActive(true);
            heatlhImage[2].gameObject.SetActive(true);
        }

        if (Health == 2)
        {
            heatlhImage[0].gameObject.SetActive(true);
            heatlhImage[1].gameObject.SetActive(true);
            heatlhImage[2].gameObject.SetActive(false);
        }

        if (Health == 1)
        {
            heatlhImage[0].gameObject.SetActive(true);
            heatlhImage[1].gameObject.SetActive(false);
            heatlhImage[2].gameObject.SetActive(false);
        }

        if (Health <= 0)
        {
            heatlhImage[0].gameObject.SetActive(false);
            heatlhImage[1].gameObject.SetActive(false);
            heatlhImage[2].gameObject.SetActive(false);

            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Health -= 1;
        }
    }
}
