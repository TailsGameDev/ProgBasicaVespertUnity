using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    MovePlayer scriptQueAnda;

    // Start is called before the first frame update
    void Start()
    {
        scriptQueAnda = GetComponent<MovePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        scriptQueAnda.Move(Input.GetKey("w"),Input.GetKey("a"),Input.GetKey("s"),Input.GetKey("d"));     
    }
}
