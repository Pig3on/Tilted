using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class LevelManager : MonoBehaviour
{
    public GameObject[] Levels = null;

    //todo create a object pool
    private GameObject currentLevel = null;

    public CameraManager cameraManager;

    private void Awake()
    {
        Levels = Resources.LoadAll<GameObject>("Levels");
    }
    public void SpawnLevel(int id, bool isDemo = false)
    {
        GameObject level = Levels[id];
        if(level != null)
        {
           GameObject levelInstance = Instantiate(level, this.transform);

            levelInstance.GetComponent<Level>().demoMode = isDemo;
            currentLevel = levelInstance;
            if (cameraManager != null) {

                cameraManager.SetPlayingCameraBearing(levelInstance.transform, null);
                cameraManager.SwitchToLevelView();
            }
        }
    }

    public void RemoveCurrentLevel() {
        if(currentLevel != null)
        {
            Destroy(currentLevel);
        }
    }

    public int GetTotalLevels()
    {
        return Levels.Length;
    }
}
