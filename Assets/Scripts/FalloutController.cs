using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalloutController : MonoBehaviour
{

    [SerializeField]
    GameObject controller;


    [SerializeField]
    Transform[] checkpoints;

    Vector3 checkpointPosition;

    Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        checkpointPosition = controller.transform.position;   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentPosition = controller.transform.position;

        for (int i = 0; i < checkpoints.Length; i++)
        {
            if (Vector3.Distance(currentPosition, checkpoints[i].position) < 10f)
            {
                
                checkpointPosition = checkpoints[i].position;
            }
        }

        if (currentPosition.y < -200f) controller.transform.position = checkpointPosition;
        Debug.Log(checkpointPosition);
    }
}
