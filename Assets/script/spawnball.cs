using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnball : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform shootingPoint;  // Assign this to the hand/controller transform
    public float maxDistance = 5f;
    public float lineShowTimer = 0;

    public LineRenderer linePrefab;

    public OVRInput.RawButton shootingButton;
    void Update()
    {
        if (OVRInput.GetDown(shootingButton))
        {
            ShootBall();
        }
    }

    
    public void ShootBall()
    {
        Debug.Log("Shooting");

        LineRenderer line = Instantiate(linePrefab);
        line.positionCount = 2;
        line.SetPosition(0, shootingPoint.position);

        Vector3 endPoint = shootingPoint.position + shootingPoint.forward * maxDistance;

        line.SetPosition(1,endPoint);

        Destroy(line.gameObject,lineShowTimer);
    }
}
