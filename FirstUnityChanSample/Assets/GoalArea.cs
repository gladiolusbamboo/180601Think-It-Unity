using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalArea : MonoBehaviour
{
  public static bool myGoal = false;

  public void OnTriggerEnter(Collider collider)
  {
    if (collider.tag == "Player")
    {
      myGoal = true;
    }
  }
}
