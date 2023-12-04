using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 1f;

    private Transform player;

    private Vector3 direction;

    private void Start()
    {
        // Find the player object by tag
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Check if the player is found
        if (player == null)
        {
            Debug.LogError("Player not found. Make sure to tag your player object with 'Player'.");
        }
        else
        {
            direction = (player.position - transform.position).normalized;
        }

    }

    private void Update()
    {
        // Move the asteroid towards the player's position
        if (player != null)
        {          
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
    }

}
