using UnityEngine;

public class BallImpact : MonoBehaviour
{
    public GameObject impactEffect;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];

        if (collision.gameObject.name.Contains("SceneMesh")) // optional filter
        {
            if (impactEffect != null)
            {
                Instantiate(impactEffect, contact.point, Quaternion.LookRotation(contact.normal));
            }
        }

        Destroy(gameObject);
    }

}
