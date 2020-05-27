using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab = null;
    // Start is called before the first frame update
    void Start()
    {
        createBall();
    }
    void createBall(){
         Instantiate(ballPrefab,this.transform.position,this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
