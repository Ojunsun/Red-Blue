using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
{
    public enum NodeState //Node의 상태
    {
        SUCCESS = 1,
        FAILURE = 2,
        RUNNING = 3
    }

    //Node의 상태를 판단하는 메서드
    public abstract class Node 
    {
        protected NodeState _nodeState;
        public NodeState nodeState => _nodeState;

        public abstract NodeState Evaluate();
    }
}
