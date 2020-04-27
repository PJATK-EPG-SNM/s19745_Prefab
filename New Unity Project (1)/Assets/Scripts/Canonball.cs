using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canonball : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        rb.velocity = transform.right * -1 * speed; 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MyPlayer"))
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
}
