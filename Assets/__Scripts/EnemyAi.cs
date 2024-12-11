using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAi : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public GameObject playerchar;
    public GameObject notspawn;

    //partol
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //state
    public float sightRange;
    public bool playerInSightRange;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        
    }
    //was going to try to move them away from spawn
    /*private Vector3 GetPosition()
    {
        return notspawn.transform.position;

    }
    */
    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (!playerInSightRange) Patroling();
        if (playerInSightRange) ChasePlayer();
    }
    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;
        //readched
        if(distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
    private void SearchWalkPoint()
    {
        float randomZ= Random.Range(-walkPointRange, walkPointRange);
        float randomX= Random.Range(-walkPointRange,walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z +randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f ,whatIsGround))
            walkPointSet = true;
    }
    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("MainMenu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //Application.Quit();
        }
    }
}
