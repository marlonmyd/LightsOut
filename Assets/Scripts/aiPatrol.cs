using UnityEngine;
using System.Collections;

public class aiPatrol : MonoBehaviour {

    public Transform[] points = new Transform [10];
    private int destPoint = 0;
    private NavMeshAgent agent;

    public Transform Player;
    public bool isChasing = false;


    void Start()
    {

        Player = GameObject.Find("Player").transform;

        //find patrol points
        points[0] = GameObject.Find("Point1").transform;
        points[1] = GameObject.Find("Point2").transform;
        points[2] = GameObject.Find("Point3").transform;
        points[3] = GameObject.Find("Point4").transform;
        points[4] = GameObject.Find("Point5").transform;
        points[5] = GameObject.Find("Point6").transform;
        points[6] = GameObject.Find("Point7").transform;
        points[7] = GameObject.Find("Point8").transform;
        points[8] = GameObject.Find("Point9").transform;
        points[9] = GameObject.Find("Point10").transform;
       
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();

       
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (agent.remainingDistance < 0.5f)
            GotoNextPoint();

        if (isChasing==true)
        {
            agent.destination = Player.position;
        }

    }
}
