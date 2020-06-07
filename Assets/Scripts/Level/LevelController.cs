
using UnityEngine;

public class LevelController
{
    private Transform transform;
    private int speed;
    private Quaternion origin = Quaternion.identity;



    public LevelController(Transform transform, int speed)
    {
        this.origin = Input.gyro.attitude;
        this.transform = transform;
        this.speed = speed;

        Input.gyro.enabled = true;
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

    private Quaternion ConvertRightHandedToLeftHandedQuaternion(Quaternion rightHandedQuaternion)
    {
        return new Quaternion(-rightHandedQuaternion.x,
                               -rightHandedQuaternion.z,
                               -rightHandedQuaternion.y,
                                rightHandedQuaternion.w);
    }
}

