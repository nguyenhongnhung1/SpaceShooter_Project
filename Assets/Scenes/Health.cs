using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(
                explosionPrefab,
                transform.position,
                transform.rotation
            );
            Destroy(explosion, 1f);
        }

        Destroy(gameObject);
    }
}

