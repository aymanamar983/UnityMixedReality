using UnityEngine;
using Oculus;
public class spawnball : MonoBehaviour
{
    public GameObject ballPrefab;
    //public Transform shootingPoint;  // <--- assign this in the inspector
    public float force = 5f;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
   
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * force;

    }
}
