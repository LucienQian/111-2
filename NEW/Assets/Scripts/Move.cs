using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 goal = new Vector3(3, 0, 5);

    void Start()
    {
        goal = goal * 0.01f;
    }

    void Update()
    {
        this.transform.Translate(goal);
    }
}
