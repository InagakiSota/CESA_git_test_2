using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float walkFroce;                            

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector3(1,0,0);

        if (Input.GetKey(KeyCode.RightArrow))
		{
            rb.AddForce(direction * walkFroce, ForceMode.Acceleration);
		}

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(direction * -walkFroce, ForceMode.Acceleration);
        }
    }
}
