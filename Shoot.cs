using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cambio1
//Cambio2

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float shootForce;
    public Transform shootPoint;

    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation).GetComponent<Rigidbody>().AddForce(shootPoint.forward * shootForce);
        }
    }
}
