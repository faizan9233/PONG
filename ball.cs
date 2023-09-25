using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject player1;
    GameObject player2;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(startdelay());

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    IEnumerator startdelay()
    {
        int randomrangeX = Random.Range(-1, 2);
        int randomrangeY = Random.Range(-1, 2);
        if(randomrangeX == 0)
        {
            randomrangeX = 1;
        }
        rb.velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2(6*randomrangeX, 6*randomrangeY);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player1"))
        {
            if(player1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(6, 6);
            }
            else if(player1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(6, -6);

            }else
            {
                rb.velocity = new Vector2(6, 0);
            }


        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            if (player2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-6, 6);
            }
            else if (player1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-6, -6);

            }
            else
            {
                rb.velocity = new Vector2(-6, 0);
            }


        }



        if (collision.gameObject.CompareTag("RightWall"))
        {
            transform.position = new Vector2(0, 0);
            StartCoroutine(startdelay());
        }
        else if (collision.gameObject.CompareTag("LeftWall"))
        {
            transform.position = new Vector2(0, 0);
            StartCoroutine(startdelay());
        }


    }

}
