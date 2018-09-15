using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour {

    private NavMeshAgent agent;
    private GameObject targetOB;
    public float speed = 10f;
    private Transform target;
    private int waveIndex = 0;
    bool finished;


    // Use this for initialization
    void Start()
    {
        finished = false;
        agent = GetComponent<NavMeshAgent>();
        targetOB = GameObject.Find("EndValidation");
        agent.SetDestination(targetOB.transform.position);
        //target = WayPoints.points[0];
    }

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Finish")
        {
            if (!finished)
            {
                Destroy(gameObject, 1f);
                targetOB.GetComponent<HeadQuaters>().TakeDamage();
                finished = true;
            }
            
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }
    void GetNextWaypoint()
    {
        if (waveIndex >= WayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        waveIndex++;
        target = WayPoints.points[waveIndex];
    }*/


}
