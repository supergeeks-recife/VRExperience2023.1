using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float force = 10f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Atirar();
        }
        
    }

    public void Atirar()
    {
        GameObject createdBullet = Instantiate(bullet);
        createdBullet.transform.position = transform.position;

        Rigidbody bullet_rig = createdBullet.GetComponent<Rigidbody>();
        Camera cam = Camera.main;
        Vector3 direction = cam.transform.forward + transform.up * 0.5f;

        bullet_rig.AddForce(direction * force, ForceMode.Impulse);
        //bullet_rig.velocity = cam.transform.rotation * Vector3.forward * speed;
    }
}
