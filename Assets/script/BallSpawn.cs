using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BallSpawn : MonoBehaviour
{
    public GameObject Prefab;
    public float shootForce = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            shootBall();
        }
    }

    void shootBall()
    {
        GameObject ball = Instantiate(Prefab, transform.position, transform.rotation);
        Rigidbody rb = ball.GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * shootForce, ForceMode.Impulse);
        
    }
}
