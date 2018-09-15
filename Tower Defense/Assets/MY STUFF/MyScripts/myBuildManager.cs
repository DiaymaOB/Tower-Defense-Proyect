using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myBuildManager : MonoBehaviour {

    public static myBuildManager Instance;
    public GameObject standardTurretPrefab, secondTurretPrefab, turretToBuild;

    void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("More than one BuildManager in scene");
            return;
        }
        Instance = this;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
