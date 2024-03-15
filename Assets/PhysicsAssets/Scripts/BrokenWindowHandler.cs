using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BrokenWindows
{
    public class BrokenWindowHandler : MonoBehaviour
    {
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Kevin"){
                Debug.Log("E");
        }
        }
    }
}