using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendPressure : MonoBehaviour
{
    private Move move;
    private int lose = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        move = FindObjectOfType<Move>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            move.speed = lose;
        }   
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            move.speed = 20;
        }
    }
}
