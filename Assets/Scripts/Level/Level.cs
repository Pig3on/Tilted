using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour
{

    private LevelController levelController;
    private LevelLogic levelLogic;

    public bool demoMode;

    public GameManager GameManager;
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
        this.SoundManager = GameObject.FindGameObjectWithTag(Tags.SOUND_MANAGER)?.GetComponent<SoundManager>();
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
        this.GameManager.LevelFinished();
        this.SoundManager.PlayClip(Clips.CLAP);

    }
    public void OnFail()
    {
        this.GameManager.LevelFailed();
        this.SoundManager.PlayClip(Clips.AWW);
    }
}