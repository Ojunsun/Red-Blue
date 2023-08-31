using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourTree;

public class SimpleEnemyBrain : EnemyBrain
{
    private Node _topNode;
    private NodeState _beforeTopState;

    protected override void Start()
    {
        base.Start();
        ConStructAITree();  
    }

    private void ConStructAITree()
    {
        //공격에 관련 된 노드
        Transform me = transform;
        RangeNode _shootingRange = new RangeNode(3f, _targetTrm, me);
        ShootNode _shootNode = new ShootNode(_navAgent, this, 1.5f);
        Sequence _shootSeq = new Sequence(new List<Node> { _shootingRange, _shootNode });

        //chasing 만들기
        RangeNode _chasingRange = new RangeNode(10f, _targetTrm, me);
        ChaseNode _chasingNode = new ChaseNode(_targetTrm, _navAgent, this);
        Sequence _chasingSeq = new Sequence(new List<Node> { _chasingRange, _chasingNode });

        _topNode = new Selector(new List<Node> { _shootSeq, _chasingSeq });
    }

    private void Update()
    {
        _topNode.Evaluate();
        if(_topNode.nodeState == NodeState.FAILURE && _beforeTopState != NodeState.FAILURE)
        {
            TryToTalk("백수");
        }

        _beforeTopState = _topNode.nodeState;
    }
}
