using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    
    private void Start()
    {
        PrintInstructions();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }

    private void PrintInstructions()
    {
        Debug.Log("We are learning to move");
        Debug.Log("Move using arrow keys or WASD.");
        Debug.Log("Don't touch the walls.");
    }
}
