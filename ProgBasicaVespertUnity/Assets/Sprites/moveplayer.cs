using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour

   
{
    public float vel = 5;

    // Update is called once per frame
    void Update()
    {
        Move(true, true, true, true);
    }
    void Move(bool w,bool a, bool s, bool d)


    {
       float speed = vel * Time.deltaTime;
        Vector3 novaPos = transform.position;
        if (w) { novaPos = novaPos + new Vector3(0, speed, 0); }
        if (d) { novaPos = novaPos + new Vector3(speed,0, 0); }
        transform.position = novaPos;
    }
}

