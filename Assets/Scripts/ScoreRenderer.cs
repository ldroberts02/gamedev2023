using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRenderer : MonoBehaviour
{

    public SpriteRenderer onesPlace;
    public SpriteRenderer tensPlace;
    public SpriteRenderer hundredsPlace;
    public SpriteRenderer thousandsPlace;
    public GameObject scoreSystem;
    public List<Sprite> numbersList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSprites(); //change this to on score, update sprites.
    }

    void UpdateSprites()
    {
       onesPlace.sprite = numbersList[scoreSystem.GetComponent<ScoreManager>().gameScore % 10];
       tensPlace.sprite = numbersList[(scoreSystem.GetComponent<ScoreManager>().gameScore /10) % 10];
       hundredsPlace.sprite = numbersList[(scoreSystem.GetComponent<ScoreManager>().gameScore /100) % 10];
       thousandsPlace.sprite = numbersList[(scoreSystem.GetComponent<ScoreManager>().gameScore /1000) % 10];
    }


}
