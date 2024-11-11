using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation
    public Vector3 rotationDirection = Vector3.up; // Direction of rotation

    void Update()
    {
        // Rotate the object around the specified axis at the specified speed
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
