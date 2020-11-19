using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("walked into the box bruh");
        GlobalAmmo.CurrentAmmo += 10;
        this.gameObject.SetActive(false);
    }
}