using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    void Update()
    {
        InternalAmmo = CurrentAmmo;
        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
    }
}
