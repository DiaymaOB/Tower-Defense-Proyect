using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorretBuild : MonoBehaviour {

    myBuildManager myManager;
    WavesBehaviour myWaves;
    private float playerUp;
    public Text layerText;

    [SerializeField] private GameObject machineGunPrefab;
    [SerializeField] private GameObject holdingWeapon;
    string energy;

    public void CreateWeapon(string weaponType)
    {
        if (weaponType == "machineGun" && playerUp >= 4 || playerUp >= 4)
        {
            holdingWeapon = Instantiate(machineGunPrefab, Input.mousePosition, Quaternion.identity);
        }
    }

    // Use this for initialization
    void Start () {
        playerUp = 12f;
        layerText.text = playerUp.ToString();
        myManager = myBuildManager.Instance;
        myWaves = WavesBehaviour.Instance;
	}
	
    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard turret");
        playerUp = -4;
        layerText.text = playerUp.ToString();
        myManager.SetTurretToBuild(myManager.standardTurretPrefab);
    }

    public void PurchaseAnotherTurret()
    {
        Debug.Log("Another turret");
        myManager.SetTurretToBuild(myManager.secondTurretPrefab);
    }

    void Update()
    {
        if (myWaves.validation == true)
        {
            playerUp += Time.deltaTime;
            layerText.text = Mathf.Round(playerUp).ToString();
        }
        if (playerUp <= 0)
        {
            layerText.text = "0";
        }
        else
        {
            layerText.text = Mathf.Round(playerUp).ToString();
        }
        if (float.Parse(layerText.text) >= 4)
        {
            energy = layerText.text;

            if (holdingWeapon != null)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                if (Physics.Raycast(ray, out hitInfo))
                {
                    holdingWeapon.transform.position = hitInfo.point;
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (hitInfo.transform.CompareTag("Available"))
                        {
                            print("clock");
                            holdingWeapon = null;
                            Destroy(hitInfo.collider);

                            playerUp -= 4;
                            layerText.text = playerUp.ToString();
                        }
                    }
                }
            }
        }


    }
}
