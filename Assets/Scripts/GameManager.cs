using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class GameManager : MonoBehaviour
{

    public CinemachineVirtualCamera vCamera;
    private CinemachineTrackedDolly dolly;
    // Start is called before the first frame update
    void Start()
    {
        dolly = vCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(dolly.m_PathPosition);
          if(dolly.m_PathPosition == 2)
            {
                dolly.m_PathPosition = 0;
            }else
            {
                dolly.m_PathPosition = 2;
            }

        }
    }
}
