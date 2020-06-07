using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab = null;

    private CameraManager CameraManager;
    public Level parent;

    private void Awake()
    {
        this.CameraManager = GameObject.FindGameObjectWithTag(Tags.CAMERA_MANAGER)?.GetComponent<CameraManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!parent.demoMode)
        {
            createBall();
        }
    }
    void createBall(){
        GameObject instance = Instantiate(ballPrefab,this.transform.position,this.transform.rotation);
        CameraManager.SetPlayingCameraBearing(instance.transform, instance.transform);
        CameraManager.SetPlayerCameraBearing(instance.transform, instance.transform);
        CameraManager.SwitchToLevelView();
    }
}
