using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    public Transform goal;
    public float speed = 1;
    public float closePoint = 0.5f;
    public float rotSpeed = 5;
    

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x,
                                        this.transform.position.y,
                                        goal.position.z);

        Vector3 direction = lookAtGoal - this.transform.position;
        Vector3 directionVertical = lookAtGoal - goal.transform.position; 
        Debug.DrawRay(this.transform.position, direction, Color.green);
        Debug.DrawRay(goal.transform.position, directionVertical, Color.red);

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                Quaternion.LookRotation(direction),
                                                Time.deltaTime * rotSpeed);

        if (Vector3.Distance(this.transform.position, lookAtGoal) > closePoint)
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }


    }
}
