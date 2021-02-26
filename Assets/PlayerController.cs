using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum State
{
    WAIT,
    HOLD,
    RUN,
    ATTACK,
}
public class PlayerController : MonoBehaviour
{
    private NavMeshAgent _agent;
    public Vector3 targetPositon;

    public State state;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.WAIT:
                _agent.SetDestination(transform.position);
                break;
            case State.HOLD:
                break;
            case State.RUN:
                if (targetPositon != null)
                {
                    _agent.SetDestination(targetPositon);
                }
                break;
            case State.ATTACK:
                
                break;
        }
    }

    public void RUN(Vector3 targetPosition)
    {
        state = State.RUN;
        this.targetPositon = targetPosition;
    }
}
