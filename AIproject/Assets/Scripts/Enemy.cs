using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Vector3 lastKnownPlayerPos;

    public float walkPointRange;
    public Transform player;
    public float speed = 5f;
    public NavMeshAgent agent;
    public float visionAngle = 120f;
    public float detectionRange = 3;
    //public float health;
   // public float maxHelath;                       wanted to set up health for a challenge. There is no point in using it with the spawnner is having issues
    private bool isPLayerInVisionCone = false;
    public float damage;
    // Start is called before the first frame update
    public void Start()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        for (int Enemy = 100; Enemy > 99; Enemy--) ;
       
    }


    public void SetPlayerInVisionCone(bool isVisible)
    {
        isPLayerInVisionCone = isVisible;

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * speed);
        if (player && agent != null)
        {
            if (agent.remainingDistance >= agent.stoppingDistance)
            {
                agent.SetDestination(player.transform.position);
            }
        }
        if (Vector3.Distance(transform.position, player.position) <= 1)
        {
            lastKnownPlayerPos = player.transform.position;

        }
        Vector3 directionToPlayer = (player.position - transform.position).normalized;

        float angleToPLayer = Vector3.Angle(transform.forward, directionToPlayer);
        if (angleToPLayer < visionAngle / 2)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, directionToPlayer, out hit, detectionRange))
            {
                if (hit.transform == player)
                {
                    lastKnownPlayerPos = player.transform.position;

                }

            }

        }
       /* if(health == 0)
        {
            Destroy(gameObject);
        }
       */ 
    }
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerController>().health -= 1;
    }

}
