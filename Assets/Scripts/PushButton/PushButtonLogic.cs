using UnityEngine;

public class PushButtonLogic
{

    Animator animator;
    public void CheckIfPressed(Collision collision, bool shouldBePressed)
    {
        if (collision.gameObject.CompareTag(Tags.BALL))
        {
            animator.SetBool("isPressed", shouldBePressed);
        }
    }
}