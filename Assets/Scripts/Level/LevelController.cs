
using UnityEngine;

public class LevelController
{
    private Transform transform;
    private int speed;
    public LevelController(Transform transform, int speed)
    {
        this.transform = transform;
        this.speed = speed;
    }


    public void UpdateLocation()
    {
        float transX = Input.GetAxis("Horizontal") * speed;
        float transY = Input.GetAxis("Vertical") * speed;

        Vector3 targetDirection = new Vector3(transY * Time.deltaTime, 0f, transX * Time.deltaTime);
        targetDirection = Camera.main.transform.TransformDirection(targetDirection);
        targetDirection.y = 0.0f;

        transform.Rotate(targetDirection);
    }
}

