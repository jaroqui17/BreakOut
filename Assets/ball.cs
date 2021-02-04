using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ball : MonoBehaviour
{
    float xVel = 0;
    float yVel = 0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yVel = 4;
        xVel = 5;
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xVel, yVel);   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "BounceX")
        {
            xVel = -xVel;
            xVel *= 1.01f;
        }
        if (collision.transform.tag == "BounceY")
        {
            yVel = -yVel;
            yVel *= 1.02f;
        }

        if(collision.transform.tag == "brickX")
        {
            xVel = -xVel;
            xVel *= 1.01f;
            Destroy(collision.transform.parent.gameObject);
            ScoreAndLives.score += 1;
            ScoreAndLives.blocksBroken += 1;
        }
        if (collision.transform.tag == "brickY")
        {
            yVel = -yVel;
            yVel *= 1.02f;
            Destroy(collision.transform.parent.gameObject);
            ScoreAndLives.score += 1;
            ScoreAndLives.blocksBroken += 1;
        }
        if (collision.transform.tag == "loseLife")
        {
            ScoreAndLives.lives -= 1;
            ScoreAndLives.blocksBroken = 0;
            SceneManager.LoadScene(ScoreAndLives.currLvl);
        }
    }
}
