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
        //新向量(水平)
        Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);

        //this.transform.LookAt(goal.position);

        //舊向量(可傾斜)
        Vector3 direction = goal.position - this.transform.position;//目標物的向量
        Debug.DrawRay(this.transform.position, direction, Color.blue);

        this.transform.LookAt(lookAtGoal);

        if(direction.magnitude > closePoint)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);//殭屍移動
        }

    }
}
