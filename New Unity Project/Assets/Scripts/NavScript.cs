using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavScript : MonoBehaviour
{ 
    public List<Transform> destination;
    private NavMeshAgent cat;
    private int currentDestination;
    public float distanceThreshold = 1;
    public float gap;

    // Start is called before the first frame update
    void Start()
    {
        cat = GetComponent<NavMeshAgent>();
        currentDestination = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cat.remainingDistance < distanceThreshold)
        {
            NextDestination();
        }

        cat.SetDestination(destination[currentDestination].position);

        gap = cat.remainingDistance;
    }

    public void NextDestination()
    {
        currentDestination++;

        if (currentDestination > destination.Count - 1)
        {
            currentDestination = 0;
        }

        cat.SetDestination(destination[currentDestination].position);
    }
}
