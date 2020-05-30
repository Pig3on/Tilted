using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    private GoalLogic goalLogic;

    private IFinishable Level;

    public void SetLevel(IFinishable level)
    {
        this.Level = level;
        this.goalLogic = new GoalLogic(this.Level);
    }

    void Awake()
    {
        this.goalLogic = new GoalLogic(this.Level);
    }

    private void OnTriggerEnter(Collider other)
    {
      
            goalLogic.onGoalCollision(other);

    }
 

}
