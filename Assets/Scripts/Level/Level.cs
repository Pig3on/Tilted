using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour
{

    private LevelController levelController;
    private LevelLogic levelLogic;

    public bool demoMode;

    public GameManager GameManager;
    public TimeManager TimeManager;
    public SoundManager SoundManager;

    public Goal Goal;

    [Header("Speed of the rotation")]
    public int speed;
    
    // Start is called before the first frame update
    
    void Awake() {

        if(demoMode) {
            return;
        }
        this.levelController = new LevelController(this.transform, this.speed);
        this.levelLogic = new LevelLogic();
        this.GameManager = GameObject.FindGameObjectWithTag(Tags.GAME_MANAGER)?.GetComponent<GameManager>();
        this.TimeManager = GameObject.FindGameObjectWithTag(Tags.TIME_MANAGER)?.GetComponent<TimeManager>();
    }

    void Update()
    {
        if(demoMode)
        {
            transform.Rotate(0, 20 * Time.deltaTime, 0);
            return;
        }
        this.levelController.UpdateLocation();
    }

    public void OnFihish()
    {
        Debug.Log("FInished");
        this.GameManager.LevelFinished();
        this.TimeManager.StopCount();


    }
    public void OnFail()
    {
        Debug.Log("DFail");
        this.GameManager.LevelFailed();
        this.TimeManager.StopCount();
    }

    public void OnStart()
    {
        this.TimeManager.StartCount();
    }
}