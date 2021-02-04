using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    float speed = 8f;
    Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float x = transform.position.x;
        if (Input.GetKey(KeyCode.RightArrow)) rb.velocity = new Vector2(speed, 0);
        else if (Input.GetKey(KeyCode.LeftArrow)) rb.velocity = new Vector2(-speed, 0);
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)) 
            rb.velocity = new Vector2(0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("speedBoost")) {
            Destroy(collision.gameObject);
            StartCoroutine(speedBoost());
        }
    }

    IEnumerator speedBoost()
    {
        speed = 15f;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);

        speed = 8f;
    }
}
