using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerrb;
    [SerializeField]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical1 = Input.GetAxis("Vertical");
        float vertical2 = Input.GetAxis("Vertical2");

     
       

        if(gameObject.CompareTag("Player1"))
        {
            playerrb.velocity = new Vector2(0, vertical1) * speed;
        }
        if(gameObject.CompareTag("Player2"))
        {
            playerrb.velocity = new Vector2(0, vertical2) * speed;
        }
        
    }
}
