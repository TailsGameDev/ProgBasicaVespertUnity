using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float vel = 5;

    public void move(bool w, bool a, bool s, bool d)
    {

	float speed = vel * Time.deltaTime;
    	Vector3 novaPos = transform.position;
	if(w){ novaPos = novaPos + new Vector3(0,speed, 0); }
	if(s){ novaPos = novaPos + new Vector3(0,-speed, 0); }
	if(d){ novaPos = novaPos + new Vector3(speed,0, 0); }
	if(a){ novaPos = novaPos + new Vector3(-speed,0, 0); }
	this.transform.position = novaPos;
    }
}
        
	
        
	