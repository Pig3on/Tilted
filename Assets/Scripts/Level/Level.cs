using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IFinishable {
    void OnFihish();
}
public class Level : MonoBehaviour, IFinishable
{

    private LevelController levelController;
    private LevelLogic levelLogic;

    [Header("Speed of the rotation")]
    public int speed;
    
    // Start is called before the first frame update
    
    void Awake() {
        this.levelController = new LevelController(this.transform, this.speed);
        this.levelLogic = new LevelLogic();
    }

    void Update()
    {
        this.levelController.UpdateLocation();
    }

    public void OnFihish()
    {
        Debug.Log("Finished");
    }
}