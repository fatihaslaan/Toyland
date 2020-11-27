using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject panel;
    float time = 1.5f;
    int FindableObjectCount=3;
    bool ndone = true;
    List<int> tid=new List<int>();
    public int cinsiyet=1;
    void Update()
    {
        time -= Time.deltaTime;
        if(time<=0.0f&&ndone)
        {
            ndone = false;
            while(FindableObjectCount>tid.Count)
            {
                int t;
                t = Random.Range(1, Global.allids.Count + 1);
                if(!(tid.Contains(t)))
                    tid.Add(t);
		        else
                    continue;
                Global.selectedids.Add(t);
            }
            foreach(Objects o in Global.allobjects)
            {		
                if(Global.selectedids.Contains(o.getid()))
                {
                    Global.showedobjects.Add(o);
                }
            }
            float tpost = (ChangeScene.male)?1.7f:-1.83f;          
			float xyeni = (ChangeScene.male)?-10.1f:-2.65f;          
			float yyeni = (ChangeScene.male)?1.341f:1.06f;          
			float zyeni = (ChangeScene.male)?-6.6f:-1.83f;   
				int turn = 0;
            foreach(Objects o in Global.showedobjects)
            {
                //spawn target objects in male room (the ones we looking for)
				if(ChangeScene.male){
					if(turn == 1) {yyeni = 0.768f;}
					else if(turn == 2) {yyeni = 0.26f;}
					Instantiate(o.getobject(), new Vector3(-10.1f, yyeni, -6.1f), Quaternion.identity).transform.localScale=new Vector3(0.01f,0.15f,0.15f);
					//target objects spawned to the board
					tpost -= 0.6f;
				}
				else{
					//spawn target objects in female room
					Debug.Log(yyeni);		
					if(turn == 1) {zyeni = -1.53f;}
					else if(turn == 2) {yyeni = 0.889f; zyeni = -1.715f;}
					Instantiate(o.getobject(), new Vector3(-2.843f, yyeni, zyeni), Quaternion.identity).transform.localScale=new Vector3(0.01f,0.2f,0.22f);
					//target objects spawned to the board
				}
				turn++;
            }
        }
        if(Global.leftobjects<=0)
        {
            panel.SetActive(true);
        }
    }
}
