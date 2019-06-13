using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputPlayer : MonoBehaviour
{
    movimentacao scriptQueAnda;
   
    void Start()
    {
        scriptQueAnda = GetComponent<movimentacao>();
    }

   
    void Update()
    {
        bool w = Input.GetKey("w");
        bool a = Input.GetKey("a");
        bool s = Input.GetKey("s");
        bool d = Input.GetKey("d");
        scriptQueAnda.move(w , a , s , d);



        scriptQueAnda.move(Input.GetKey("w") , Input.GetKey("a"), Input.GetKey("s"), Input.GetKey("d"));
    }
}
