using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    public SpriteBehavior spriteTarget;
    public GameObject scoreSystem;
    public GameObject ActionTargetComponent;
    public int lastActionTimer = 0;
    int actionTimertarget = 3; //will set lastActionTimer to this so i dont have to repeat code so much
    float timeElapsed = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreSystem.GetComponent<ScoreManager>().startGame)
        {
         if (Input.GetKeyDown(KeyCode.Space))
            {
                if (spriteTarget.positionNum == 1 && spriteTarget.upper == true && ActionTargetComponent.GetComponent<ActionScript>().upperLeftActive == true && lastActionTimer == 0)
                {
                    ActionTargetComponent.GetComponent<ActionScript>().ActiveTarget(TargetName.UPPER_LEFT, false);
                    scoreSystem.GetComponent<ScoreManager>().onScore(); //to add 1 to score
                    lastActionTimer = actionTimertarget;
                }
                if (spriteTarget.positionNum == 1 && spriteTarget.upper == false && ActionTargetComponent.GetComponent<ActionScript>().lowerLeftActive == true && lastActionTimer == 0)
                {
                    ActionTargetComponent.GetComponent<ActionScript>().ActiveTarget(TargetName.LOWER_LEFT, false);
                    scoreSystem.GetComponent<ScoreManager>().onScore(); //to add 1 to score
                    lastActionTimer = actionTimertarget;
                }
                if (spriteTarget.positionNum == 3 && spriteTarget.upper == true && ActionTargetComponent.GetComponent<ActionScript>().upperRightActive == true && lastActionTimer == 0)
                {
                    ActionTargetComponent.GetComponent<ActionScript>().ActiveTarget(TargetName.UPPER_RIGHT, false);
                    scoreSystem.GetComponent<ScoreManager>().onScore(); //to add 1 to score
                    lastActionTimer = actionTimertarget;
                }
                if (spriteTarget.positionNum == 3 && spriteTarget.upper == false && ActionTargetComponent.GetComponent<ActionScript>().lowerRightActive == true && lastActionTimer == 0)
                {
                    ActionTargetComponent.GetComponent<ActionScript>().ActiveTarget(TargetName.LOWER_RIGHT, false);
                    scoreSystem.GetComponent<ScoreManager>().onScore(); //to add 1 to score
                    lastActionTimer = actionTimertarget;
                }
            }
         if (Input.GetKeyDown(KeyCode.LeftArrow) && lastActionTimer == 0)
            {
                if (spriteTarget.positionNum >= 1)
                {
                    spriteTarget.positionNum --;
                }
                lastActionTimer = actionTimertarget;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && lastActionTimer == 0)
            {
                if (spriteTarget.positionNum <= 2)
                {
                    spriteTarget.positionNum ++;
                }
                lastActionTimer = actionTimertarget;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && lastActionTimer == 0)
            {
                spriteTarget.upper = true;
                lastActionTimer = actionTimertarget;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && lastActionTimer == 0)
            {
                spriteTarget.upper = false;
                lastActionTimer = actionTimertarget;
            }
        }
        else if (scoreSystem.GetComponent<ScoreManager>().startGame ==  false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                scoreSystem.GetComponent<ScoreManager>().gameStart();

            }
        }

        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 0.05f)
        {
            timeElapsed = timeElapsed % 0.05f;
            if (lastActionTimer >=1)
            {
                lastActionTimer = (lastActionTimer - 1);
            }
        }
    }
}
