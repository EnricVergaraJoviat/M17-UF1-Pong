using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GOAL_TYPE
{
    GOAL_LEFT,
    GOAL_RIGHT,
}
public class Goal : MonoBehaviour
{
    
    public GameManager gm;
    public GOAL_TYPE type; 
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    // when the GameObjects collider arrange for this GameObject to travel to the left of the screen
    void OnTriggerEnter2D(Collider2D col)
    {
        if (type == GOAL_TYPE.GOAL_LEFT)
        {
            Debug.Log("GOAL of player Right");    
        }
        else
        {
            Debug.Log("GOAL of player Left");
        }

        gm.Goal(type);
    }
}
