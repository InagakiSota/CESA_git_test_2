using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravityTest : MonoBehaviour
{
    [SerializeField] GameObject plane;
    [SerializeField] float gravityScale;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void FixedUpdate()
	{
        var direction = new Vector3(0,
            plane.transform.position.y - this.transform.position.y,
            plane.transform.position.z - this.transform.position.z);

        direction.Normalize();

        //‰Á‘¬“x‚ð‰Á‚¦‚é
        rb.AddForce(gravityScale * direction, ForceMode.Acceleration);
    }
}
