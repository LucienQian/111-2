using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform goal;
    public float closePoint = 1;

    void Start()
    {
        
    }

    void Update()
    {
        this.transform.LookAt(goal.position);
        Vector3 direction = goal.position - this.transform.position;//目標物的向量
        Debug.DrawRay(this.transform.position, direction, Color.red);
        if(direction.magnitude > closePoint)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);//殭屍移動
        }

    }
}
