using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float rotateSpeed = 5;
    public GameObject cannon;
    public GameObject bullet;
    public float bulletSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, -Input.GetAxis("Horizontal") * rotateSpeed);
        Shoot();
    }
    public void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone;
            bulletClone = Instantiate(bullet, transform.position, transform.rotation);
            bulletClone.GetComponent<Rigidbody2D>().velocity(0, bulletSpeed);
        }
    }
}
