using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFollowing : MonoBehaviour
{
    [SerializeField] 
    int speed = 2;

    GameObject target;
    Vector3 dir;
    private void Start()
    {
        target = GameObject.Find("WOW");
        dir = target.transform.position - transform.position;
    }

    private void Update()
    {
        Following();
    }

    void Following()
    {
        transform.position += dir * speed * Time.deltaTime;
        dir.Normalize();

        if(Vector3.Distance(transform.position, target.transform.position) < 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
