using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanGun : MonoBehaviour
{
    public Transform gunBarrel;

    // Update is called once per frame
    void Update()
    {
        int layermask = 1 << 8;
        layermask = ~layermask;

        RaycastHit hit;

        if (Physics.Raycast(gunBarrel.position, gunBarrel.forward, out hit, Mathf.Infinity, layermask))
        {
            Debug.DrawRay(gunBarrel.position, gunBarrel.forward * hit.distance, Color.green);
        }
        else
        {
            Debug.DrawRay(gunBarrel.position, gunBarrel.forward * 9000, Color.red);
        }
    }
}
