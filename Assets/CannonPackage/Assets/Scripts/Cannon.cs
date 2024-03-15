using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Cannon : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Animator animator;
    public Transform fireSocket;
    public float rotationRate;
    public ParticleSystem FireFX;
//    [Tooltip("Cannonball limit for the level (0 = no limit)")]
//    public int Ammo = 0;
    private int Strokes = 0;
    private int Par = 3;
    public static bool Win;
    public static int Stars = 0;
    public static int PowerInput = 15;
    public Text PowerDisplay;
    bool StarsSaid = false;
    public Animator scoreAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Win = false;
        int PowerInput = Projectile.Power;
        HideStars();
    }

    // Update is called once per frame
    void Update()
    {
        scoreAnimator.SetInteger("Stars", 0);
        float aimInput = Input.GetAxis("Horizontal");
        aimInput *= rotationRate * Time.deltaTime;
        //Rotate the cannon around the right Local Axis
        transform.Rotate(Vector3.right * aimInput, Space.Self);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (PowerInput < 20)
            {
                PowerInput++;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (PowerInput > 1)
            {
                PowerInput--;
            }
        }
        PowerDisplay.text = PowerInput.ToString();
        Projectile.Power = PowerInput;
        if(Win)
        {
            ShowScore(Par);
        }
    }

    void Fire()
    {
        animator.SetTrigger("FireCannon");
        Instantiate(projectilePrefab, fireSocket.position, fireSocket.rotation);
        FireFX.Play();
        Strokes++;
    }
    void ShowScore(int Par)
    {
       if (Win)
        {
            if (Strokes <= ((Par - 3 > 1) ? Par - 3 : Par - 2))
            {
                Stars = 3;

            }
            else if (Strokes <= Par)
            {
                Stars = 2;
            }
            else if (Strokes >= Par && Strokes <= Par + 2)
            {
                Stars = 1;
            }
            else if (Strokes >= Par)
            {
                Stars = 0;
            }
            //print("Stars: " + Stars);
            StarsSaid = true;
            Text ScoreDisplay = GameObject.Find("Score").GetComponent<Text>();
            ScoreDisplay.text = (Stars.ToString() + " Stars!");
            scoreAnimator.SetInteger("Stars", 3);

        }
    }
    void HideStars()
    {
        scoreAnimator.SetInteger("Stars", 0);
    }
}
