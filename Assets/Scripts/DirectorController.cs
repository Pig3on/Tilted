using UnityEngine;
using UnityEngine.Playables;

public class DirectorController : MonoBehaviour
{
    public Level level;
    private PlayableDirector director;
    // Start is called before the first frame update
    void Awake()
    {
        if (!level.demoMode)
        {
            director = this.GetComponent<PlayableDirector>();
            director.Play();
        }
      
    }
}
