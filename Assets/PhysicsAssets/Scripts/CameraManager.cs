using UnityEngine;
using System.Collections;
public class SimpleTimer: MonoBehaviour {
    public float Camera1SwitchTime = 3.0f;
    public Camera Camera1;
    public Camera Camera2;
    void Start(){
        Camera1.enabled = true;
        Camera1.GetComponent<AudioListener> ().enabled  =  true;
        Camera2.enabled = false;
        Camera2.GetComponent<AudioListener> ().enabled  =  false;
    }
    void Update() {
      if(Camera1SwitchTime > 0.0f){
      Camera1SwitchTime -= Time.deltaTime;
      }else if (Camera1SwitchTime <= 0.0f) {
        timerEnded();
      }
    }
    void timerEnded() {
        Camera1.enabled = false;
        Camera1.GetComponent<AudioListener> ().enabled  =  false;
        Camera2.enabled = true;
        Camera2.GetComponent<AudioListener> ().enabled  =  true;
    } 
    }