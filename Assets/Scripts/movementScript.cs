using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class movementScript : MonoBehaviour {

    private GameObject player;

    private NavMeshAgent navMeshAgent;

    private NavMeshHit navMeshHit;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");

        navMeshAgent = player.GetComponent<NavMeshAgent>();
	}
	
	public void OnPointerDown()
    {
        print("OnPointerDown Called!");
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100f))
        {
            Debug.DrawLine(navMeshAgent.gameObject.transform.position, hit.point, Color.red, 10f);
            navMeshAgent.SetDestination(hit.point);
        }
    }
}
