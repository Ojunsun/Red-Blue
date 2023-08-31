using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class EnemyBrain : MonoBehaviour
{
    [SerializeField] protected Transform _targetTrm;

    protected NavMeshAgent _navAgent;
    public NavMeshAgent navMeshAgent => _navAgent;

    private void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
    }

    protected virtual void Start()
    {

    }

    public void TryToTalk(string text, float timer = 1f)
    {
        Debug.Log(text);
    }
}
