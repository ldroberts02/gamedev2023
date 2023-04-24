using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TargetName {UPPER_LEFT,UPPER_RIGHT,LOWER_LEFT,LOWER_RIGHT};

public class ActionScript : MonoBehaviour
{
    public SpriteRenderer upperLeft;
    public SpriteRenderer lowerLeft;
    public SpriteRenderer upperRight;
    public SpriteRenderer lowerRight;
    public bool upperLeftActive;
    public bool lowerLeftActive;
    public bool upperRightActive;
    public bool lowerRightActive;

    public void ActiveTarget(TargetName targetAction, bool isActive)
    {
        switch (targetAction)
        {
            case TargetName.UPPER_LEFT:
            {
                upperLeftActive = isActive;
                upperLeft.enabled = isActive;
                break;
            }
            case TargetName.LOWER_LEFT:
            {
                lowerLeftActive = isActive;
                lowerLeft.enabled = isActive;
                break;
            }
            case TargetName.UPPER_RIGHT:
            {
                upperRightActive = isActive;
                upperRight.enabled = isActive;
                break;
            }
            case TargetName.LOWER_RIGHT:
            {
                lowerRightActive = isActive;
                lowerRight.enabled = isActive;
                break;
            }
            default:
            {
                break;
            }
        }
    }

}
