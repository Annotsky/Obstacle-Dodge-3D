using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private GameObject[] projectiles;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        foreach (GameObject projectile in projectiles)
        {
            if (projectile != null)
                projectile.SetActive(true);
        }
    }
}
