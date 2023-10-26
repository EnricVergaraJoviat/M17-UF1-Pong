using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float initialSpeed = 5f;
    public Rigidbody2D rb;
    void Start()
    {   
        LaunchBall();
    }

    void LaunchBall()
    {
        
        float x = Random.Range(0, 2) == 0 ? -1 : 1; // Dirección aleatoria en X
        float y = Random.Range(0, 2) == 0 ? -1 : 1; // Dirección aleatoria en Y
        rb.velocity = new Vector2(x, y).normalized * initialSpeed; // Asigna la velocidad inicial
    }
}
