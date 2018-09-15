using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesBehaviour : MonoBehaviour {

    public static WavesBehaviour Instance;
    public Transform enemy;
    public Transform spawnPoint;
    public float timer = 5f;
    private float countDown = 2f;
    private int waveIndex = 0;
    public bool validation = false;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("More than one WavesBehaviour script in this scene");
            return;
        }
        Instance = this;
    }

    // Update is called once per frame
    void Update () {
        /*if (countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countDown = timer;
        }
        countDown -= Time.deltaTime;*/
    }

    //COROUTINE 
    IEnumerator SpawnWave()
    {
        while (true)
        {
            waveIndex++;

            for (int i = 0; i < waveIndex; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }
            yield return new WaitForSeconds(5f);
        }
    }

    public void StartWave()
    {
        validation = true;
        StartCoroutine(SpawnWave());
        countDown = timer;
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
