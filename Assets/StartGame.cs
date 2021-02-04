using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Go()
    {
        ScoreAndLives.currLvl = 1;
        SceneManager.LoadScene(1);
    }
}
