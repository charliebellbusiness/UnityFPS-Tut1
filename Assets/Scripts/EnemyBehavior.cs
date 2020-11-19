using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    public int EnemyHealth = 10;

    void DeductPoints(int DamageAmount)
    {

        EnemyHealth -= DamageAmount;

        // Fill damage number popup text
        TextMesh textObject = GameObject.Find("DamageNumber").GetComponent<TextMesh>();
        textObject.text = "-" + DamageAmount.ToString();

        // Play damage number popup animation
        Animation anim = GetComponent<Animation>();
        anim.Play("DamagePopup");

    }

    void Die() {

        // Play death animation
        Animation anim = GetComponent<Animation>();
        anim.Play("EnemyDeath");
        
    }

    void Update()
    {

        TextMesh textObject = GameObject.Find("Health").GetComponent<TextMesh>();
        textObject.text = EnemyHealth.ToString() + " HP";

        if (EnemyHealth <= 0)
        {
            Die();
        }
}

    void Delete()
    {
        Destroy(gameObject);
    }
}