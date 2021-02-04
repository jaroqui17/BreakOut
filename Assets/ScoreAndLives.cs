using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreAndLives : MonoBehaviour
{

    public static int score;
    public static int lives = 3;
    public Text textScore;
    public Text textLives;
    public static int currLvl = 0;
    int[] blocksToBreak = {14, 5};
    public static int blocksBroken = 0;
    // Start is called before the first frame update
    private void Start()
    {
        DontDestroyOnLoad(this);
    }
    void Update()
    {
        textScore.text = "Score: " + score.ToString();
        textLives.text = "Lives: " + lives.ToString();
        if (lives < 1) {
            SceneManager.LoadScene("GameOver");
        }
        if (blocksBroken == blocksToBreak[currLvl]) {
            currLvl++;
            blocksBroken = 0;
            SceneManager.LoadScene(currLvl);
        }
    }

}
