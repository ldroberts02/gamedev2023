using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockBehavior : MonoBehaviour
{
    public int timeHour = System.DateTime.Now.Hour;
    public int timeMinute = System.DateTime.Now.Minute;
    public GameObject digitOne;
    public SpriteRenderer oneRender;
    public GameObject digitTwo;
    public SpriteRenderer twoRender;
    public GameObject digitThree;
    public SpriteRenderer threeRender;
    public GameObject digitFour;
    public SpriteRenderer fourRender;
    public GameObject digitMorning;
    public GameObject digitNoon;
    public GameObject digitColon;    
    public int minuteOnePlace;
    public int hourOnePlace;
    public int minuteTenPlace;
    public List<Sprite> numbersList;

    public GameObject ActionTargetBehavior;
    public GameObject ScoreManager;

    float elapsed = 0f;

    public int rand = 0;



    void Start()
    {
        timeHour = System.DateTime.Now.Hour;
        timeMinute = System.DateTime.Now.Minute;
        TimeUpdate();
        //Debug.Log("Time is: "+ timeHour+ ':'+ timeMinute);
        
    }

    void Update()
    {
     elapsed += Time.deltaTime;
     if (elapsed >= 1f)
     {
        elapsed = elapsed % 1f; //will update every ~1 second
        TimeUpdate();
     }


 }

void TimeUpdate()
{

    



    if (timeHour == 0 || (timeHour >= 10 && timeHour <= 12) || (timeHour >= 22 && timeHour <= 23)) //if time is 0:00, 10-12, or 22:00-23:00, disable the 1 character in clock.
    {
        digitOne.SetActive(true);
    }
    else
    {
        digitOne.SetActive(false);
    }

    if (timeHour <= 11)
    {
        digitMorning.SetActive(true);
        digitNoon.SetActive(false);
    }
    if (timeHour >= 12)
    {
        digitMorning.SetActive(false);
        digitNoon.SetActive(true);
    }

    //here starts the 2nd digit, the one that represents the ones place in hours. needs cleaning up when possible.

    if (timeHour >= 9 && timeHour != 10 && timeHour != 11 && timeHour != 12 && timeHour != 22 && timeHour != 23)
    {
        hourOnePlace = (timeHour - 12);
    }
    if (timeHour <= 9 && timeHour != 0)
    {
        hourOnePlace = timeHour;
    }
    if(timeHour == 10 || timeHour == 22)
    {
        hourOnePlace = 0;
    }
    if (timeHour == 11 || timeHour == 23)
    {
        hourOnePlace = 1;
    }
    if (timeHour == 12 || timeHour == 0)
    {
        hourOnePlace = 2; //figure out a one line if for 10, 11, and 12 am AND pm later
    }

    //here starts the fourth digit, the ones place in minutes.

    if (timeMinute >= 10)
    {
        minuteOnePlace = ((timeMinute % 10));
    }
    if (timeMinute <= 9)
    {
        minuteOnePlace = timeMinute;
    }
    
    //here starts the third digit, the tens place in minutes.
    if (timeMinute <= 9)
    {
        minuteTenPlace = 0;
    }
    if (timeMinute >=10)
    {
        minuteTenPlace = timeMinute / 10;
    }

    //render all the sprites now, math is done.
    timeHour = System.DateTime.Now.Hour;
    timeMinute = System.DateTime.Now.Minute;
    twoRender.sprite = numbersList[hourOnePlace];
    threeRender.sprite = numbersList[minuteTenPlace];
    fourRender.sprite = numbersList[minuteOnePlace];
    digitColon.SetActive (!digitColon.activeInHierarchy);

    rand = Random.Range(1,5);
    if(ScoreManager.GetComponent<ScoreManager>().startGame == true)
        ActionActivation(rand);


}


public void ActionActivation(int targetNumber) //just gonna make 1-4, with them in this order: upper left, lower left, upper right, lower right.
{
    if (targetNumber == 1)
        ActionTargetBehavior.GetComponent<ActionScript>().ActiveTarget(TargetName.UPPER_LEFT, true);

    if (targetNumber == 2)
        ActionTargetBehavior.GetComponent<ActionScript>().ActiveTarget(TargetName.LOWER_LEFT, true);

    if (targetNumber == 3)
        ActionTargetBehavior.GetComponent<ActionScript>().ActiveTarget(TargetName.UPPER_RIGHT, true);

    if (targetNumber == 4)
        ActionTargetBehavior.GetComponent<ActionScript>().ActiveTarget(TargetName.LOWER_RIGHT, true);

}








}