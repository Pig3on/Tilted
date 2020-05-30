using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private IFinishable Level;

    private CameraManager cameraManager;

    public void SetLevel(IFinishable level)
    {
        this.Level = level;
    }

    void Awake()
    {
        cameraManager = GameObject.FindGameObjectWithTag(Tags.CAMERA_MANAGER).GetComponent<CameraManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Tags.BALL))
        {
            cameraManager.SwitchToPlayerView();
            Level.OnFihish(other.gameObject.transform);
        }

    }
 

}
