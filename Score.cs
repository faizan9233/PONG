using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int player1Score = 0;
    int player2Score = 0;
    public TextMeshProUGUI player1Scoretxt;
    public TextMeshProUGUI player2Scoretxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("RightWall"))
        {
            player1Score++;
            player1Scoretxt.text = player1Score.ToString();
            Debug.Log("right");
        }
        else if(collision.gameObject.CompareTag("LeftWall"))
        {
            player2Score++;
            player2Scoretxt.text = player2Score.ToString();
            Debug.Log("left");
        }

    }

}
