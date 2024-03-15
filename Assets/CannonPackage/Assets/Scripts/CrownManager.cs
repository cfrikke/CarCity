using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrownManager : MonoBehaviour
{
    public GameObject explosionPrefab;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Instantiate explosion prefab at projectile position
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Cannon.Win = true;
        }

    }

}
