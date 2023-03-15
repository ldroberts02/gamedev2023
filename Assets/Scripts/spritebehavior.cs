using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spritebehavior : MonoBehaviour
{
    public SpriteRenderer spriteR;
    public Sprite testSprite;

    
    void Start()
    {
        spriteR.sprite = testSprite;     		
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
