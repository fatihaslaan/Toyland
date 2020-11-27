using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketWarning : MonoBehaviour
{
    public GameObject red;
    void Update()
    {
        Rigidbody CharRigidBody = GameObject.Find("RigidBodyFPSController").GetComponent<Rigidbody>();
        if (Vector3.Distance(this.gameObject.transform.position, CharRigidBody.transform.position) < 1.5f)
        {
            red.SetActive(true);
        }
        else
        {
            red.SetActive(false);
        }
    }
}
