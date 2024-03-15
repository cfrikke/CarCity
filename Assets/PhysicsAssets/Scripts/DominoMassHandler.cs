using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoMassHandler : MonoBehaviour
{
    public static Collision collision;   
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    transform.position += Time.deltaTime * Vector3.down;

           /* if (OnTriggerEnter(Trigger.TriggerCollider)){
                Debug.Log("E");
            }*/
    }

    private void OnTriggerEnter(Collider Trigger){
        rb.mass = 64;
    }
}
