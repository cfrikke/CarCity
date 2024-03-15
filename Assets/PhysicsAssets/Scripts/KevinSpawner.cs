using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRubyLightningBolt;
using KevinSummoner;

public class KevinSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.transform.position.y < 40){
            LightningBoltScript Lightning = GameObject.Find("SimpleLightningBoltAnimatedPrefab").GetComponent<LightningBoltScript>();
            LightningBoltScript Lightning2 = GameObject.Find("SimpleLightningBoltAnimatedPrefab (1)").GetComponent<LightningBoltScript>();
            LightningBoltScript Lightning3 = GameObject.Find("SimpleLightningBoltAnimatedPrefab (2)").GetComponent<LightningBoltScript>();
            LightningBoltScript Lightning4 = GameObject.Find("SimpleLightningBoltAnimatedPrefab (3)").GetComponent<LightningBoltScript>();
            LightningBoltScript Lightning5 = GameObject.Find("SimpleLightningBoltAnimatedPrefab (4)").GetComponent<LightningBoltScript>();
            SpawnKevin Kevin = GameObject.Find("Kevin").GetComponent<SpawnKevin>();
            Lightning.Trigger();
            Lightning2.Trigger();
            Lightning3.Trigger();
            Lightning4.Trigger();
            Lightning5.Trigger();
            Kevin.SpawnKevinTheCube();
        }
    }


}
