using UnityEngine;
using UnityEngine.AI;

public class PoliceChase : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
