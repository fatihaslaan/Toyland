using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
	//for picking up target objects
    AudioSource sound;
    int id;
    void Start()
    {
		//giving ids to objects
        sound = GameObject.Find("RigidBodyFPSController").GetComponent<AudioSource>();
        Global.tempid++;
        id = Global.tempid;
        Global.allids.Add(id);        
        Global.allobjects.Add(new Objects(this.gameObject, id));
    }
    void OnMouseDown()
    {
        Rigidbody CharRigidBody = GameObject.Find("RigidBodyFPSController").GetComponent<Rigidbody>();
        if(Vector3.Distance(this.gameObject.transform.position,CharRigidBody.transform.position)<1.5f)
        {
            if (Global.selectedids.Contains(id))
            {
                sound.Play();
                Destroy(this.gameObject);
                Global.leftobjects--;
            }
        }
        
    }
}
