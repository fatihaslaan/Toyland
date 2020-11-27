using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawl : MonoBehaviour
{
    public static bool crawl=false;
    GameObject cam1;
    GameObject cam2;
    void Start()
    {
        cam1 = GameObject.Find("MainCamera");
        cam2 = GameObject.Find("CCamera");
    }
    public void buttonpressed()
    {
        if(crawl)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);            
            crawl = false;
        }
        else
        {
            cam2.SetActive(true);
            cam1.SetActive(false);            
            crawl = true;
        }
    }
}
