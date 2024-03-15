using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KevinRoller : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        var anchor = transform.position + new Vector3(-0.5f, -0.5f, 0);
        var axis = Vector3.Cross(Vector3.up, Vector3.left);
        StartCoroutine(Roll(anchor, axis));
    }

    IEnumerator Roll(Vector3 anchor, Vector3 axis)
    {
        for(int i = 0;i < (90 / _rollSpeed); i++)
        {
            transform.RotateAround(anchor, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }

    }
}
