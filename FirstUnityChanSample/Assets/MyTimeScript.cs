using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTimeScript : MonoBehaviour
{
  float time;
  void Start()
  {
    time = 0.0f;
  }

  // Update is called once per frame
  void Update()
  {
    myGoal();
  }

  private void myGoal()
  {
    if(GoalArea.myGoal == false)
    {
      time += Time.deltaTime;
      int now = (int)time;
      GetComponent<Text>().text = now.ToString();
      
    }
    else
    {
      var msg = GameObject.Find("msg");
      msg.GetComponent<Text>().text = "GOAL!";
    }
  }
}
