using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SantaController : MonoBehaviour {
    private NavMeshAgent santa;
    private GameObject player;

    // Start is called before the first frame update
    void Start() {
        santa = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        santa.SetDestination(player.transform.position);
    }
}
