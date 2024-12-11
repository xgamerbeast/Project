using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject laserPrefab; // Reference to the Laser prefab
    public Transform firePoint;    // The position where lasers are spawned
    public float laserSpeed = 20f; // Speed of the laser

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Shoot when Space is pressed
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Create a laser instance at the fire point
        GameObject laser = Instantiate(laserPrefab, firePoint.position, firePoint.rotation);

        // Apply force to the laser
        Rigidbody rb = laser.GetComponent<Rigidbody>();
        rb.velocity = firePoint.up * laserSpeed;

        // Destroy the laser after 5 seconds to avoid clutter
        Destroy(laser, 5f);
    }
}
