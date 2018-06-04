using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanJump : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {
    var myAnimator = GetComponent<Animator>();
    if (Input.GetKey(KeyCode.Space))
    {
      //Debug.Log("Jump!!");
      myAnimator.SetBool("Jump", true);
    }

    var state = myAnimator.GetCurrentAnimatorStateInfo(0);
    if (state.IsName("Locomotion.Jump"))
    {
      //Debug.Log("Jump??");
      myAnimator.SetBool("Jump", false);
    }

  }
}
