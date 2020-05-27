using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    private GoalLogic goalLogic;

    public IFinishable level;
   

    void Awake()
    {
        this.goalLogic = new GoalLogic(this.level);
    }

    private void OnCollisionEnter(Collision other) {
        goalLogic.onGoalCollision(other);
    }

}
