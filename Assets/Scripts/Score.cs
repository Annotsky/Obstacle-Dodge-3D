using UnityEngine;

public class Score : MonoBehaviour
{
    private int _countOfCollisions;
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            _countOfCollisions++;
            Debug.Log("Count of bumps:" + _countOfCollisions);
        }
    }
}
