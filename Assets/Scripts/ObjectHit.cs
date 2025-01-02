using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(gameObject.name + " collision with " + other.gameObject.name);
    }
}
