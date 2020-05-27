
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

        transform.Rotate(transY * Time.deltaTime, 0, transX * Time.deltaTime);
    }

    private Quaternion ConvertRightHandedToLeftHandedQuaternion(Quaternion rightHandedQuaternion)
    {
        return new Quaternion(-rightHandedQuaternion.x,
                               -rightHandedQuaternion.z,
                               -rightHandedQuaternion.y,
                                rightHandedQuaternion.w);
    }
}

