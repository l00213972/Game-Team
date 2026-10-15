using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;
    public Vector3 offset = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        if (target == null)
            return;

        float targetX = target.position.x + offset.x;

        // Keep the camera's current Y and Z
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, offset.z);

        float smooth = 1f - Mathf.Exp(-smoothSpeed * Time.deltaTime);

        transform.position = Vector3.Lerp(transform.position, targetPosition, smooth);
    }
}

