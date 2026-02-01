using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit by: " + collision.gameObject.name);

        if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
