using UnityEngine;

public class LaserCollision : MonoBehaviour
{
    public GameObject explosionEffect; 

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Meteor"))
        {
            
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, other.transform.position, Quaternion.identity);
            }

            Destroy(other.gameObject); 
            Destroy(gameObject);       
        }
    }
}
