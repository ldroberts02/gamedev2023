using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpriteBehavior : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    public Sprite MiddleSprite;
    public Sprite LeftSprite;
    public Sprite RightSprite;
    public int positionNum = 0;
    public bool movetest = false;
    public Vector3 location1 = new Vector3(-6,0,0);
    public Vector3 location2 = new Vector3(6,0,0);
    
    void Start()
    {
        spriteRender.sprite = MiddleSprite;     		
    }

    // Update is called once per frame
    void Update()
    {

        if (positionNum == 1)
        {
            spriteRender.sprite = LeftSprite;
        }
        if (positionNum == 2)
        {
            spriteRender.sprite = MiddleSprite;
        }
        if (positionNum == 3)
        {
            spriteRender.sprite = RightSprite;
        }

    }
}

//What needs to be done atm:
/* 
use multiple "blank" entities to grab their location for the player to teleport to (so gameobject.pos = entity1.pos or whatev)
use arrow keys to move between positions based on a "1, 2, 3 system" where 2 is default, left will move to 1, and right will move to 3 based on where it is (so 1 to 2, 2 to 3, or 3 to 2)
*/