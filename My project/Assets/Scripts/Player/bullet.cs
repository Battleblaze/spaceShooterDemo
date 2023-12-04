using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 0.1f;
    }

    private void FixedUpdate()
    {
        var trans = transform;
        rb.MovePosition(transform.position + transform.up * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Meteor"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Player"))
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
