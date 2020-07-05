using UnityEngine;
using PlayingScene;
public class TiltsCounter : MonoBehaviour
{
    public int tilts = 0;
    public UiManager UiManager;
    private bool horizontalAxisInUse = false;
    private bool vertivalAxisInUse = false;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        //horizontal axis getButtonDown
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (horizontalAxisInUse == false)
            {
                tilts += 1;
                UiManager.UpdateTiltNumber(tilts);
                horizontalAxisInUse = true;
            }
           
        }
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            horizontalAxisInUse = false;
        }

        //vertical axis getButtonDown
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            if (vertivalAxisInUse == false)
            {
                tilts += 1;
                UiManager.UpdateTiltNumber(tilts);
                vertivalAxisInUse = true;
            }

        }
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            vertivalAxisInUse = false;
        }
    }

}