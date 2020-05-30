﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraManager : MonoBehaviour
{

    public GameObject playingCameraObj;
    public GameObject playerCameraObj;
    private CinemachineFreeLook playingCamera;
    private CinemachineFreeLook playerCamera;
    // Start is called before the first frame update

    private void Awake()
    {
        this.playingCamera = playingCameraObj.GetComponent<CinemachineFreeLook>();
        this.playerCamera = playerCameraObj.GetComponent<CinemachineFreeLook>();
    }
    public void SwitchToPlayerView() {

        Debug.Log("Switched");
        playingCameraObj.SetActive(false);
        playerCameraObj.SetActive(true);
    }
    public void SwitchToLevelView()
    {
        playingCameraObj.SetActive(true);
        playerCameraObj.SetActive(false);
    }

    public void SetPlayingCameraBearing(Transform lookAt, Transform follow)
    {
        if(lookAt != null)
        {
            this.playingCamera.LookAt = lookAt;
        }
        if (follow != null)
        {
            this.playingCamera.Follow = follow;
        }
    }
}