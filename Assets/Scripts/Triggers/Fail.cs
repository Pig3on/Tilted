using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fail : MonoBehaviour
{
    private CameraManager cameraManager;

    public Level parent;

    void Awake()
    {
        if (!parent.demoMode)
        {
            cameraManager = GameObject.FindGameObjectWithTag(Tags.CAMERA_MANAGER)?.GetComponent<CameraManager>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Tags.BALL))
        {
            cameraManager.SwitchToPlayerView();
            parent.OnFail();
        }

    }


}
