using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float vel = 5; // mudou agora
    void Update()
    {
	//Iput.GetKey(KeyCode.W)
	Move(true, false, false, true);

    }

    void Move(bool w, bool a, bool s, bool d)
    {
	float speed = vel * Time.deltaTime; // mudou agora
	Vector3 novaPos = transform.position;
	if(w){ novaPos = novaPos + new Vector3(0,speed, 0); }
	if(s){ novaPos = novaPos + new Vector3(0,-speed, 0); }
	if(d){ novaPos = novaPos + new Vector3(speed,0, 0); }
	if(a){ novaPos = novaPos + new Vector3(-speed,0, 0); }
	transform.position = novaPos;
    }
}

        
	
        
	