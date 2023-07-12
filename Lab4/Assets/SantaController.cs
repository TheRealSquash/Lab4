using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SantaController : MonoBehaviour {
    private NavMeshAgent santa;
    private GameObject player;
    public Transform[] patrolPoints;
    [SerializeField] private int curDest = 1;
    public float detectionRange = 30f;

    // Start is called before the first frame update
    void Start() {
        santa = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        transform.position = patrolPoints[0].position;
    }

    // Update is called once per frame
    void Update() {
        if(Distance() > detectionRange) Patrol();
        else Chase();
    }

    private void Patrol() {
        Debug.Log(Vector3.Distance(transform.position, patrolPoints[curDest].position) > 0.1f);
        if(Vector3.Distance(transform.position, patrolPoints[curDest].position) > 0.05f) santa.SetDestination(patrolPoints[curDest].position);
        else Increment();
    }

    private void Increment() {
        if(curDest < patrolPoints.Length - 1) curDest ++;
        else curDest = 0;
    }

    private void Chase() {
        santa.SetDestination(player.transform.position);
    }

    public bool IsCrawling() {
        return Distance() > 15;
    }

    public bool IsRunning() {
        return Distance() <= 15;
    }

    private float Distance() {
        return Vector3.Distance(transform.position, player.transform.position);
    }
}
