using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitWithButton : MonoBehaviour {

    // Use this for initialization
    private SteamVR_Controller.Device quitButton;
    public GameObject pauseText;

    public bool paused = false;
    private float timeScale;
    void Start () {
        pauseText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost)).GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            if (paused)
            {
                paused = false;
                Time.timeScale = timeScale;

            }
            Application.LoadLevel("Menu");
            
        }

        if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost)).GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            if (paused)
            {
                paused = false;
                Time.timeScale = timeScale;

            }
            Application.LoadLevel("Menu");
        }


        if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost)).GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            if (!paused)
            {
                timeScale = Time.timeScale;
                Time.timeScale = 0.0f;
                paused = true;
                pauseText.SetActive(true);
            }
            else
            {
                paused = false;
                Time.timeScale = timeScale;
                pauseText.SetActive(false);
            }
        }

    }
}
