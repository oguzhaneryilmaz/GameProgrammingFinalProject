using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Meteorite)
    {
        if(Meteorite.tag == "MyMeteorite")
        {
            SceneManager.LoadScene(0);
        }
    }
}
