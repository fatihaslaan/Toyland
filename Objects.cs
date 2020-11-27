using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    GameObject thisobject;
    int thisid;
    public Objects(GameObject obj,int id)
    {
        thisobject = obj;
        thisid = id;
    }
    public GameObject getobject()
    {
        thisobject.GetComponent<Rigidbody>().useGravity = false;
        return thisobject;
    }
    public int getid()
    {
        return thisid;
    }
}
