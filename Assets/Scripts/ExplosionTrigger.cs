using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
   
  
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tank")) 
        {

            ParticleSystem explosionParticleSystem = GetComponent<ParticleSystem>();
            explosionParticleSystem.Play(); // Start the explosion particle effect


        }
       
    }
}
