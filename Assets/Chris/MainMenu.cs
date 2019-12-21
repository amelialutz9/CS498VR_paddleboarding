using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    UnityEvent e;
    public GameObject[] buttons;
    public GameObject leftControllerGO;
    private SteamVR_TrackedController leftController;
    public EventSystem esystem;
    int selectedButton = 0;
    private void Start()
    {
        leftController = leftControllerGO.GetComponent<SteamVR_TrackedController>();
        leftController.TriggerClicked += selectAndChangeSceneCallback;
        leftController.PadClicked += HandlePadClicked;
    }
    private void Update()
    {
        
    }

    void HandlePadClicked(object sender, ClickedEventArgs ee)
    {
        if (ee.padY < 0)
        {
            selectedButton = (selectedButton + 1) % buttons.Length;
            esystem.SetSelectedGameObject(buttons[selectedButton]);
        } else if (ee.padY > 0)
        {
            selectedButton = (selectedButton - 1 + buttons.Length) % buttons.Length;
            esystem.SetSelectedGameObject(buttons[selectedButton]);
        }
        Debug.Log("Selected Button: " + selectedButton);
    }

    void selectAndChangeSceneCallback(object sender, ClickedEventArgs ee)
    {
        selectAndChangeScene();
    }

    void selectAndChangeScene()
    {
        Button bref = esystem.currentSelectedGameObject.GetComponent<Button>();
        bref.onClick.Invoke();
    }

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);//Loads Scene
    }

    public void exitApp()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
