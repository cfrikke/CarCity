using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KevinSummoner{
    public class SpawnKevin : MonoBehaviour
    {
        [SerializeField] private float _rollSpeed = 1f;
        public void SpawnKevinTheCube()
        {
            Vector3 KevinSpeed = new Vector3(0, 10F * Time.deltaTime, 0);
            bool LightningGone = false;
            if (this.transform.position.y > 9)
            {
                if (!LightningGone)
                {
                    GameObject.Destroy(GameObject.Find("SimpleLightningBoltAnimatedPrefab"));
                    GameObject.Destroy(GameObject.Find("SimpleLightningBoltAnimatedPrefab (1)"));
                    GameObject.Destroy(GameObject.Find("SimpleLightningBoltAnimatedPrefab (2)"));
                    GameObject.Destroy(GameObject.Find("SimpleLightningBoltAnimatedPrefab (3)"));
                    GameObject.Destroy(GameObject.Find("SimpleLightningBoltAnimatedPrefab (4)"));
                    GameObject.Find("Kevin").GetComponent<SpawnKevin>().enabled = false;
                    var anchor = transform.position + new Vector3(5f, -5f, 0);
                    var axis = Vector3.Cross(Vector3.up, Vector3.right);
                    StartCoroutine(Roll(anchor, axis));

                }
            }
            else
            {
                transform.position += KevinSpeed;
            }

        }

        IEnumerator Roll(Vector3 anchor, Vector3 axis)
        {
            for (int i = 0; i < (90 / _rollSpeed); i++)
            {
                transform.RotateAround(anchor, axis, _rollSpeed);
                yield return new WaitForSeconds(0.01f);
            }
            GameObject.Find("Window").GetComponent<BreakableWindow>().breakWindow();
            GameObject.Find("Window (1)").GetComponent<BreakableWindow>().breakWindow();


        }
    }
}
