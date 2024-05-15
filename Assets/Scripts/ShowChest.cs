using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScript : MonoBehaviour
{
    public Transform targetPosition;
    public float speed = 5f;

    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            MoveToTarget();
        }
    }

    void MoveToTarget()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, step);

        if (transform.position == targetPosition.position)
        {
            isMoving = false;
        }
    }
}
