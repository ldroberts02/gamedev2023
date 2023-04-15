using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockBehavior : MonoBehaviour
{
    public int timeHour = System.DateTime.Now.Hour;
    public int timeMinute = System.DateTime.Now.Minute;
    public GameObject digitOne;
    public GameObject digitTwo;
    public GameObject digitThree;
    public GameObject digitFour;
    public GameObject digitMorning;
    public GameObject digitNoon;
    public GameObject digitColon;    

    public List<Sprite> numbersList;

    float elapsed = 0f;

    void Start()
    {
        timeHour = System.DateTime.Now.Hour;
        timeMinute = System.DateTime.Now.Minute;
        
        Debug.Log("Time is: "+ timeHour+ ':'+ timeMinute);
    }

    void Update()
    {
        //timeHour = System.DateTime.Now.Hour;
        //timeMinute = System.DateTime.Now.Minute;

        if (timeHour == 0 || (timeHour >= 10 && timeHour <= 12) || (timeHour >= 22 && timeHour <= 23)) //if time is 0:00, 10-12, or 22:00-23:00, disable the 1 character in clock.
        {
            digitOne.SetActive(true);
        }
        else
        {
            digitOne.SetActive(false);
        }

        //starting here will be the messiest and sloppiest job to set some sprites based on an integer. (hour int, min int)

        digitTwo.GetComponent<SpriteRenderer>();
        //digitTwo.SpriteRenderer.Sprite = numbersList[System.DateTime.Now.Hour];



     elapsed += Time.deltaTime;
     if (elapsed >= 1f)
     {
        elapsed = elapsed % 1f;
        TimeUpdate();
     }


 }

void TimeUpdate()
{
    digitColon.SetActive (!digitColon.activeInHierarchy);
}







}

