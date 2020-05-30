using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class LevelManager : MonoBehaviour
{
    public GameObject[] Levels = null;

    public CinemachineFreeLook vcam;

    private void Start()
    {
        Levels = Resources.LoadAll<GameObject>("Levels");
    }
    public void SpawnLevel(int id, Vector3 location)
    {
        GameObject level = Levels[id];
        if(level != null)
        {
           GameObject levelInstance = Instantiate(level, location, Quaternion.identity);

            vcam.LookAt = levelInstance.transform;
        }
    }
}
