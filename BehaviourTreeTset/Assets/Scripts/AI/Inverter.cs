using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
{
    public class Inverter : Node
    {
        protected Node _nodes;

        public Inverter(Node nodes)
        {
            _nodes = nodes;
        }

        public override NodeState Evaluate()
        {
            bool isAnyNodeRun = false;


            switch (_nodes.Evaluate())
            {
                case NodeState.RUNNING:
                    _nodeState = NodeState.RUNNING;
                    break;
                case NodeState.SUCCESS:
                    _nodeState = NodeState.FAILURE;
                    break;
                case NodeState.FAILURE:
                    _nodeState = NodeState.SUCCESS;
                    break;
                default:
                    break;
            }

            _nodeState = isAnyNodeRun ? NodeState.RUNNING : NodeState.SUCCESS;
            return _nodeState;
        }
    }
}
