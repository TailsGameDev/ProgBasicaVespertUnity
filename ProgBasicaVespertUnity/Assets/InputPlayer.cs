using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    Move scriptQueAnda; 

    void Start()
    {
        scriptQueAnda= this.GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
	bool w = Input.GetKey("w");
	bool a = Input.GetKey("a");
	bool s = Input.GetKey("s");
	bool d = Input.GetKey("d");
        scriptQueAnda.move(w,a,s,d);
    }
}
