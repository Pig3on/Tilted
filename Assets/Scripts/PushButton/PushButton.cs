using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    Animator animator;

    private PushButtonLogic pushButtonLogic;
    void Awake()
    {
        animator = this.GetComponent<Animator>();
        pushButtonLogic = new PushButtonLogic();
    }

    void OnCollisionEnter(Collision collision)
    {
        this.pushButtonLogic.CheckIfPressed(collision, true);

    }
    void OnCollisionExit(Collision collision)
    {
        this.pushButtonLogic.CheckIfPressed(collision, false);
    }
}