using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    public void PlayButton()
    {
        ScoreScript.ScoreNum = 0;
        SceneManager.LoadScene(1);
    }

    public void ResumeButton()
    {
        ScoreScript.ScoreNum = PauseMenu.devamScore;
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
