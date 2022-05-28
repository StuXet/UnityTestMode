using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int rand;
    int point;
    int chickenDinner = 25;
    public bool WinnerWinnerChickenDinner()
    {
        point = 55;
        return chickenDinner <= point;

    }

    public bool RandomDinner()
    {
        rand = Random.Range(0, 50);
        return chickenDinner <= rand;
    }

    //public void OnTriggerEnter(Collider coll)
    //{
    //    if (coll.gameObject.tag == "GG")
    //    {
    //        point++;
    //        Debug.Log(point);
    //    }
    //}
}