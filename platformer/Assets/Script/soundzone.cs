using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundzone : MonoBehaviour
{
    public CircleCollider2D circle;
    public GameObject phone;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        circle.GetComponent<CircleCollider2D>();
        
        audio.enabled = false;
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            audio.enabled = true;
        }
        
        
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            audio.enabled = false;
        }
        
        

    }
     
}
