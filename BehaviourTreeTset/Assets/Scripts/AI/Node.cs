using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
{
    public enum NodeState //Node�� ����
    {
        SUCCESS = 1,
        FAILURE = 2,
        RUNNING = 3
    }

    //Node�� ���¸� �Ǵ��ϴ� �޼���
    public abstract class Node 
    {
        protected NodeState _nodeState;
        public NodeState nodeState => _nodeState;

        public abstract NodeState Evaluate();
    }
}
