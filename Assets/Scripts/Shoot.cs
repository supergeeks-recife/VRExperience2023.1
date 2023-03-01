using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject createdBullet = Instantiate(bullet);
            createdBullet.transform.position = transform.position;

            Rigidbody bullet_rig = createdBullet.GetComponent<Rigidbody>();
            Camera cam = Camera.main;

            bullet_rig.velocity = cam.transform.rotation * Vector3.forward * speed;
        }
        
    }
}
