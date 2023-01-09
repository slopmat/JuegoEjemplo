using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
=======
//Cambio1
//Cambio2

>>>>>>> parent of 76ce700 (hth)
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
