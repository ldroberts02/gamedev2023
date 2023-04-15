using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private bool startGame; //false is "game not running", true is "game running"
    private int gameScore; //the score is an integer that increases with every action taken toward fixing the enemy state to 0.
    private int savedScore; //high score to save to disk. will have a reset function, with confirmation or other method to reset score.
    private bool gamestateReset; //if false, when start game is false, will act like game is JUST started. if true, will act like game is after game over.

    public SpriteBehavior spriteTarget;



    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
