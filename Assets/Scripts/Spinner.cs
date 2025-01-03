using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xRotationSpeed;
    [SerializeField] private float yRotationSpeed;
    [SerializeField] private float zRotationSpeed;

    private void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(xRotationSpeed, yRotationSpeed, zRotationSpeed);
    }
}
