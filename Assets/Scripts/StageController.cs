
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
		{
            pos.x += 0.01f;
		}
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.01f;
        }

        this.transform.position = pos;
    }
}
