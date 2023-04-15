using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    public SpriteBehavior spriteTarget;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // spriteTarget.movetest = !spriteTarget.movetest;
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (spriteTarget.positionNum >= 2)
            spriteTarget.positionNum = spriteTarget.positionNum -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (spriteTarget.positionNum <= 2)
            spriteTarget.positionNum = spriteTarget.positionNum +1;
        }

        if (spriteTarget.movetest)
        {
           // spriteTarget.gameObject.transform.position = spriteTarget.location1;
            //spriteTarget.spriteRender.sprite = spriteTarget.test1;
        }
        else if (!spriteTarget.movetest)
        {
           // spriteTarget.gameObject.transform.position = spriteTarget.location2;
           // spriteTarget.spriteRender.sprite = spriteTarget.test2;
        }        
    }
}
