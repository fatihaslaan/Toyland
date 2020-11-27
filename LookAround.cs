using UnityEngine;

public class LookAround : MonoBehaviour
{
    private Touch inittouch = new Touch();
    public Camera cam;
    public Camera cam2;
    private float rotx = 0.0f;
    private float roty = 0.0f;
    private Vector3 orgrot;
    public float rotspeed=0.5f;
    public float dir = -1;

    void Start()
    {
        if (Crawl.crawl)
            orgrot = cam2.transform.eulerAngles;
        else
            orgrot = cam.transform.eulerAngles;
        rotx = orgrot.x;
        roty = orgrot.y;
    }
    void FixedUpdate()
    {
        if (!(Input.touches.Length>0))
            return;
        if (Input.touches[0].phase == TouchPhase.Began)
        {
            inittouch = Input.touches[0];
        }
        else if(Input.touches[0].phase== TouchPhase.Moved)
        {
	    if(Input.touches[0].position.x < Screen.width/3)
		return;
            float deltax = inittouch.position.x - Input.touches[0].position.x;
            float deltay = inittouch.position.y - Input.touches[0].position.y;
            rotx -= deltay * Time.deltaTime * rotspeed*dir;
            roty+= deltax * Time.deltaTime * rotspeed*dir;
            rotx=Mathf.Clamp(rotx, -45f, 45f);
            if (Crawl.crawl)
                cam2.transform.eulerAngles = new Vector3(rotx, roty, 0f);
            else
                cam.transform.eulerAngles = new Vector3(rotx, roty, 0f);
        }
        else if(Input.touches[0].phase==TouchPhase.Ended)
        {
            inittouch = new Touch();
        }
        
    }
}
