using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab = null;

    public CinemachineFreeLook vCamera;

    // Start is called before the first frame update
    void Start()
    {
        createBall();

    }
    void createBall(){
        GameObject instance = Instantiate(ballPrefab,this.transform.position,this.transform.rotation);
        vCamera.Follow = instance.transform;
        vCamera.LookAt = instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
