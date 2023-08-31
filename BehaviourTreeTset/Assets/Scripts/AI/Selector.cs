using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
{
    public class Selector : Node
    {
        protected List<Node> _nodes = new List<Node>();

        public Selector(List<Node> nodes)
        {
            _nodes = nodes;
        }

        public override NodeState Evaluate()
        {
            foreach(var node in _nodes)
            {
                switch(node.Evaluate())
                {
                    case NodeState.RUNNING:
                        _nodeState = NodeState.RUNNING;
                        return _nodeState;
                    case NodeState.SUCCESS:
                        _nodeState = NodeState.SUCCESS;
                        return _nodeState;
                    case NodeState.FAILURE:
                        break; //���� ��, �ٸ� ��带 Ȯ���ϱ�
                    default:
                        break;
                }
            }

            _nodeState = NodeState.FAILURE;
            return _nodeState;
        }
    }
}

