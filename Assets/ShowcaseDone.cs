using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowcaseDone : MonoBehaviour
{

    public Level level;
    public GameObject cinemachineObject;
    // Start is called before the first frame update
    private void OnEnable()
    {
        if (!level.demoMode)
        {
            cinemachineObject.SetActive(false);
        }
    }
}
