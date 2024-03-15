using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float explosionForce, explosionRadius, upwardsModifier;
    public GameObject explosionFX;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyExplosion", 0.5f);
        Instantiate(explosionFX, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidbody = other.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            rigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius, upwardsModifier, ForceMode.VelocityChange);
        }
    }
    void DestroyExplosion()
    {
        Destroy(gameObject);
    }
}
