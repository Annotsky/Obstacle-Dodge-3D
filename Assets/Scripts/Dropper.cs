using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 2f;
    
    private Rigidbody _rigidbody;
    private MeshRenderer _meshRenderer;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Time.time >= timeToWait)
        {
            _meshRenderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}
