using UnityEngine;

public class GoalLogic
{

    private IFinishable level;


    public GoalLogic(IFinishable level)
    {
        this.level = level;
    }
    public void onGoalCollision(Collider collision)
    {

        if (collision.gameObject.CompareTag("BALL"))
        {
            level.OnFihish(collision.gameObject.transform);
        }
    }

}