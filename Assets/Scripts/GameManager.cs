using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _scorePlayerLeft;
    private int _scorePlayerRight;
    // Start is called before the first frame update
    void Start()
    {
        _scorePlayerLeft = 0;
        _scorePlayerRight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Goal(GOAL_TYPE type)
    {
        if (type == GOAL_TYPE.GOAL_LEFT)
        {
            _scorePlayerRight++;
        } else
        {
            _scorePlayerLeft++;
        }
        
        Debug.Log("Score player Right: " + _scorePlayerRight);
        Debug.Log("Score player Left: " + _scorePlayerLeft);
    }
}
