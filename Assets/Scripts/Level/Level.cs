using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IFinishable {
    void OnFihish(Transform position);
}
public class Level : MonoBehaviour, IFinishable
{

    private LevelController levelController;
    private LevelLogic levelLogic;

    private LevelManager LevelManager;

    public Goal Goal;

    [Header("Speed of the rotation")]
    public int speed;
    
    // Start is called before the first frame update
    
    void Awake() {
        this.LevelManager = GameObject.FindGameObjectWithTag(Tags.LEVEL_MANAGER).GetComponent<LevelManager>();
        this.levelController = new LevelController(this.transform, this.speed);
        this.levelLogic = new LevelLogic();
        this.Goal.SetLevel(this);
    }

    void Update()
    {
        this.levelController.UpdateLocation();
    }

    public void OnFihish(Transform transform)
    {
        Vector3 position = transform.position;
        position.y -= 90;

        this.LevelManager.SpawnLevel(0, position);
    }
}