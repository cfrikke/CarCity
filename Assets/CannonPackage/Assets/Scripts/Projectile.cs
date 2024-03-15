using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forceAmount = 15.0f;
    public GameObject explosionPrefab;
    public static int Power = 15;
    // Start is called before the first frame update
    void Start()
    {
        forceAmount = Power;
        rigidbody = GetComponent<Rigidbody>();
        Vector3 forceDirection = transform.forward;

        rigidbody.AddForce(forceDirection * forceAmount, ForceMode.VelocityChange);
    }


    private void OnCollisionEnter(Collision other)
    {
        print("Collided with " + other.gameObject.name);
        if (!(other.gameObject.CompareTag("Crown")))
        {
            // Instantiate explosion prefab at projectile position
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            // Destroy projectile
            Destroy(gameObject);
        }
    }
}
