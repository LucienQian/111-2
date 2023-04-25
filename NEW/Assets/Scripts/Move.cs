using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 goal = new Vector3(3, 0, 5);
    public float speed = 0.1f;

    void Start()
    {
        goal = goal * 0.1f;
    }

    void Update()
    {
        this.transform.Translate(goal.normalized * speed);
    }
}
