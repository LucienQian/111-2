using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    public GameObject[] waypoints;
    public int currentWP = 0;

    public Transform goal;
    public float speed = 1;
    public float closePoint = 0.5f;
    public float rotSpeed = 5;
    

    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("tag-waypoint");
    }

    void Update()
    {
        if (waypoints.Length == 0) return;

        Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x,
                                        this.transform.position.y,
                                        waypoints[currentWP].transform.position.z);

        Vector3 direction = lookAtGoal - this.transform.position;
        Vector3 directionVertical = lookAtGoal - waypoints[currentWP].transform.position; 
        Debug.DrawRay(this.transform.position, direction, Color.green);
        Debug.DrawRay(waypoints[currentWP].transform.position, directionVertical, Color.red);

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                Quaternion.LookRotation(direction),
                                                Time.deltaTime * rotSpeed);

        //if (Vector3.Distance(this.transform.position, lookAtGoal) > closePoint)
        //{
            //this.transform.Translate(0, 0, speed * Time.deltaTime);
        //}

        if(direction.magnitude < closePoint)
        {
            currentWP++;
            if(currentWP >= waypoints.Length)
            {
                currentWP = 0;
            }
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime);

    }
}
