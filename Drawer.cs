using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
	//open drawers
    bool exc=false;
    bool open = false;
    public GameObject drawer;
    void Start()
    {
        if(this.gameObject.name== "SM_Room_Big_Chest_Of_Drawer")
        {
            exc = true;
        }
    }
    void OnMouseDown()
    {       
        Rigidbody CharRigidBody = GameObject.Find("RigidBodyFPSController").GetComponent<Rigidbody>();
        if (Vector3.Distance(drawer.transform.position, CharRigidBody.transform.position) < 2)
        {
            if (!open)
            {
                open = true;
                if(!exc)
                    drawer.transform.position = new Vector3(drawer.transform.position.x - 0.300f, drawer.transform.position.y, drawer.transform.position.z);
                else
                    drawer.transform.position = new Vector3(drawer.transform.position.x + 0.300f, drawer.transform.position.y, drawer.transform.position.z);
            }
            else
            {
                open = false;
                if(!exc)
                    drawer.transform.position = new Vector3(drawer.transform.position.x + 0.300f, drawer.transform.position.y, drawer.transform.position.z);
                else
                    drawer.transform.position = new Vector3(drawer.transform.position.x - 0.300f, drawer.transform.position.y, drawer.transform.position.z);
            }
        }

    }
}
