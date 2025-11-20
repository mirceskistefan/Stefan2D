using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] protected float damege;

    protected void OnTriggerEnter2D(Collider2D collision)   
    {
        if(collision.tag == "Player")
            collision.GetComponent<Health>().TakeDamage(damege);
    }
}
