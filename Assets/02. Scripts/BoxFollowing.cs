using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFollowing : MonoBehaviour
{
    [SerializeField] 
    int speed = 2;

    GameObject target;
    Vector3 dir;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        target = GameObject.Find("WOW");
        dir = target.transform.position - transform.position;
    }

    private void FixedUpdate()
    {
        Following();
    }

    void Following()
    {
        rigid.velocity = dir * speed;
        dir.Normalize();

        if(Vector3.Distance(transform.position, target.transform.position) < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
