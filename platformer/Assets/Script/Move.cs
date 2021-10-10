using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private BoxCollider2D boxco;

    public Rigidbody2D rb;
    private Vector2 moveVelocity;
    Vector2 mousePos;
    public Camera cam;

    private void Start()
    {
        
        boxco = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
       
        
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput.normalized * speed;


            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
        

      
    }
    private void FixedUpdate()
    {
         
            
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            
         
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
