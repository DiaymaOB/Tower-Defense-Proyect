using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour {

    public Canvas MainCanvas, LevelCanvas;
    public Animator anim1, anim2;

    void Awake()
    {
        LevelCanvas.enabled = false;
    }

    public void LevelsOn()
    {
        LevelCanvas.enabled = true;
        MainCanvas.enabled = false;
        anim1.Play("CameraAnimation");
    }

    public void ReturnOn()
    {
        LevelCanvas.enabled = false;
        MainCanvas.enabled = true;
        anim2.Play("Reverse");
    }

    public void LoadOn()
    {
        Application.LoadLevel("MyLevel1");
    }

    public void Quit()
    {
        Application.Quit();
    }

    void Start () {
        anim1 = GetComponent<Animator>();
        anim2 = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
