using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float projectileSpeed;
    private Vector3 _playerPosition;
    
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        _playerPosition = player.transform.position;
    }

    private void Update()
    {
        FlyToPlayerAndDestroySelf();
    }
    
    private void FlyToPlayerAndDestroySelf()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                  _playerPosition,
                                         projectileSpeed * Time.deltaTime);
        if (transform.position == _playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
