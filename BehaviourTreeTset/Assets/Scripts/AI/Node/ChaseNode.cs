using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourTree;
using UnityEngine.AI;

public class ChaseNode : Node
{
    private Transform _target;
    private NavMeshAgent _agent;
    private EnemyBrain _brain;

    public ChaseNode(Transform target, NavMeshAgent agnet, EnemyBrain brain)
    {
        _target = target;
        _agent = agnet;
        _brain = brain;

    }

    public override NodeState Evaluate()
    {
        //�Ÿ�
        float distance = Vector3.Distance(_target.position, _agent.transform.position);
        if (distance > 0.2f)
        {
            _agent.isStopped = false;
            _agent.SetDestination(_target.position);
            
            if (_nodeState != NodeState.RUNNING)
            {
                _brain.TryToTalk("����");
                _nodeState = NodeState.RUNNING;
            }
        }
        else
        {
            _agent.isStopped = true;
            _nodeState = NodeState.SUCCESS;
        }
        return _nodeState;
    }
}
