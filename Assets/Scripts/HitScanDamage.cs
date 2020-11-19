using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanDamage : MonoBehaviour {

        // Currently hardcoded values, replace with function to call gun damage based on weapon id.
        public int DamageAmount = 5;
        public float TargetDistance;
        public float AllowedRange = 15.0f;

        void Update()
            {

                if (Input.GetButtonDown("Fire1")) // If shooting, raycast. If shot collides with enemy, deal damage.
                {
                    
                    // Check shot hit

                    RaycastHit Shot;

                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))

                    {
                        
                        // Check shot range
                        TargetDistance = Shot.distance;
                        if (TargetDistance <= AllowedRange)
                        {
                            
                            // Call DeductPoints method from target's behaviour script
                            Transform HitTarget = Shot.transform;
                            HitTarget.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);

                            // Play hit marker animation
                            Transform GunMechanics = gameObject.transform.Find("GunMechanics");
                            Transform CrossHair = GunMechanics.transform.Find("CrosshairCanvas");
                            Debug.Log(CrossHair);
                            Animation anim = CrossHair.GetComponent<Animation>();
                            anim.Play("HitMarker");

                        }       
                    }       

                }
            }
}