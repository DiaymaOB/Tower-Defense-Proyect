using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementValidation : MonoBehaviour {

    public Vector3 positionOffset;
    private GameObject turret;

    myBuildManager myManager;


	// Use this for initialization
	void Start () {
        myManager = myBuildManager.Instance;
	}
	
    void OnMouseDown()
    {
        if (myManager.GetTurretToBuild() == null)
        {
            return;
        }
        if (turret != null)
        {
            Debug.Log("Can´t build there!");
            return;
        }

        GameObject turretToBuild = myManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, Input.mousePosition, Quaternion.identity);
    }

    void OnMouseEnter()
    {
        if (myManager.GetTurretToBuild() == null)
        {
            return;
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
