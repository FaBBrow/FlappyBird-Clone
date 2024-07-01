using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int horizontalspeed;
    [SerializeField] private float verticalspeed;
    [SerializeField] private Rigidbody2D rb;
    public bool playable=true;
    [SerializeField] private AudioSource amýnakoyum;
    [SerializeField] private Rigidbody2D camerarb;
    private void Update()
    {
        if (playable) { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
                rb.velocity = new Vector2(rb.velocity.x, verticalspeed);
        }
            rb.velocity = new Vector2(horizontalspeed, rb.velocity.y);
            camerarb.velocity = new Vector2(horizontalspeed, camerarb.velocity.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.CompareTag("obstacle"))
            {
            amýnakoyum.Play();
            playable = false;
            rb.velocity = Vector2.zero;
            camerarb.velocity= Vector2.zero;
        }
    }
}
