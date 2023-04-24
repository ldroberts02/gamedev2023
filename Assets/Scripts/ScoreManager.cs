using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [field: SerializeField] public bool startGame {get; internal set;} //false is "game not running", true is "game running"
    [field: SerializeField] public int gameScore {get; internal set;} //the score is an integer that increases with every action taken toward fixing the enemy state to 0.
    [field: SerializeField] public int savedScore {get; internal set;} //high score to save to disk. will have a reset function, with confirmation or other method to reset score.
    [field: SerializeField] public int missNumber {get; internal set;} = 3;

    void Start() //when starting scene in unity
    {
        resetGame();
        startGame = false;
    }

    void Update()
    {
        
    }

    void resetGame() //what to call when lose state and want to return the game to non playable state
    {
        if (gameScore >= savedScore) {savedScore = gameScore;}
        gameScore = 0;
        missNumber = 3;
        startGame = false;
    }
    public void gameStart() //when setting game start from after load (press space)
    {
        startGame = true;
    }
    public void onScore() //call with //GameObjectNameHere//.GetComponent<ScoreManager>().onScore();
    {
        gameScore++;
        
        //add more here for other things, like sound, or whatever
    }

}


