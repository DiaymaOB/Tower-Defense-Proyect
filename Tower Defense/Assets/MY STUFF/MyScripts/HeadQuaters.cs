using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadQuaters : MonoBehaviour {

    private int hp;
    public Text healthDisplay;

	// Use this for initialization
	void Start () {
        hp = 10;
        healthDisplay.text = hp.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage()
    {
        hp -= 1;
        healthDisplay.text = hp.ToString();
    }
}
