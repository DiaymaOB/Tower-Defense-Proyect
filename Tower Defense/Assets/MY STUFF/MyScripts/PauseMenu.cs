using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public Canvas PauseCanvas, LevelCanvas;

    void Awake()
    {
        PauseCanvas.enabled = false;
    }
    public void LoadMenu()
    {
        PauseCanvas.enabled = true;
        LevelCanvas.enabled = true;
    }

    public void ReturnOn()
    {
        PauseCanvas.enabled = false;
        LevelCanvas.enabled = true;
    }

    public void ReturnMainMenu()
    {
        PauseCanvas.enabled = false;
        LevelCanvas.enabled = false;
        Application.LoadLevel("MyMenu");
    }
    // Use this for initialization
    void Start () {
		
	}
	
    public void StopTime()
    {
        LoadMenu();
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        /*else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }*/
    }

    public void ContinueTime()
    {
        
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    // Update is called once per frame
    void Update () {
        
    }
}
