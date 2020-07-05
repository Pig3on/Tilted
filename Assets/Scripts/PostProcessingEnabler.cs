using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class PostProcessingEnabler : MonoBehaviour
{


    public PostProcessProfile lowSettings;
    public PostProcessProfile highSettings;

    // Start is called before the first frame update
    void Start()
    {
        PostProcessVolume volume = GetComponent<PostProcessVolume>();
        bool usePostProcessing = PlayerPrefs.GetInt(PrefKeys.USE_PROCESSING) == 1;

        Debug.Log(usePostProcessing);
        if(usePostProcessing) {
            volume.profile = highSettings;
        }
        else
        {
            volume.profile = lowSettings;
        }
        
    }

    // Update is called once per fram
}
