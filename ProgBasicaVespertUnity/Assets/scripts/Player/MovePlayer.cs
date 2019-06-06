using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float vel = 8;  

    // Start is called before the first frame update
    void Update()
    {
        Move(Input.GetKey("w"), Input.GetKey("a"), Input.GetKey("s"), Input.GetKey("d"));
    }

    // Move
    void Move(bool w, bool a, bool s, bool d)
    {

        float speed = vel * Time.deltaTime;
        Vector3 novaPos = transform.position;
        if (w) { novaPos += new Vector3(0, speed, 0); }
        if (a) { novaPos -= new Vector3(speed, 0, 0); }
        if (s) { novaPos -= new Vector3(0, speed, 0); }
        if (d) { novaPos += new Vector3(speed, 0, 0); }
        transform.position = novaPos;

        
    }
}

