using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Player")]
    public GameObject player;

    public NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        // NavMeshAgentを保持しておく
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーを目指して進む
        navMeshAgent.destination = player.transform.position;
    }
}
