using UnityEngine;
using Oculus;

public class spawnball : MonoBehaviour
{
    public GameObject ballPrefab;
    //public Transform shootingPoint;  // Assign this to the hand/controller transform
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
#pragma warning disable CS0618
        rb.velocity = transform.forward * force;
#pragma warning restore CS0618


    }
}
