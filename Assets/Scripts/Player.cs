using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public KeyCode keyUp;
    public KeyCode keyDown;
    public Transform borderUp;
    public Transform borderDown;
    private void Update()
    {
        MovePaddle();
    }

    private void MovePaddle()
    {
        float move = 0;
        if (Input.GetKey(keyUp))
        {
            move = 1;
        } else if (Input.GetKey(keyDown))
        {
            move = -1;
        }
        move = move * speed * Time.deltaTime; 
        transform.Translate(0, move, 0);
        
        if (transform.position.y + 0.5 >= borderUp.position.y)
        {
            //Desfer
            transform.Translate(0, -move, 0);

        }
        
        if (transform.position.y - 0.5 <= borderDown.position.y)
        {
            //Desfer
            transform.Translate(0, -move, 0);
        }
    }

    
}
