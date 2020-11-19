using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.CurrentAmmo > 0)
        {

            //Debug.Log("Shot fired"); // check input working as intended

            // Play audio
            AudioSource gunSound = GetComponent<AudioSource>();
            // Debug.Log(gunSound); // check gunSound exists
            gunSound.Play();

            // Play animation
            Animation anim = GetComponent<Animation>();
            anim.Play("GunShot");

            // Decrease ammo count
            GlobalAmmo.CurrentAmmo -= 1;

        }

        else if (Input.GetButtonDown("Fire1"))
        {

            // Play sound
            Transform GunMechanics = gameObject.transform.Find("GunMechanics");
            
            Transform audioSource = GunMechanics.transform.Find("GunEmpty");
            AudioSource emptySound = GetComponent<AudioSource>();

            // Play animation
            Animation anim = GetComponent<Animation>();
            anim.Play("GunEmpty");

        }
    }
}