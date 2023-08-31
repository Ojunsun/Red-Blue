using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourTree;
using UnityEngine.AI;

public class ShootNode : Node
{
    private NavMeshAgent _Agent;
    private EnemyBrain _brain;

    private float _coolTime;
    private float _lastFireTime;

    public ShootNode(NavMeshAgent agent, EnemyBrain brain, float coolTime)
    {
        _Agent = agent;
        _brain = brain; 
        _coolTime = coolTime;
    }

    public override NodeState Evaluate()
    {
        _Agent.isStopped = true; //정지

        if(_lastFireTime + _coolTime <= Time.time)
        {
            _brain.TryToTalk("공격!!", 1f);
        }

        return NodeState.RUNNING;
    }
}
