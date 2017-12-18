using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;

	void Start () {

	}
	
	void Update () {

        float horizontalInput = Input.GetAxis("horizontal");
        float verticalInput   = Input.GetAxis("vertical");

        if (transform.position.y < -4.1f)
        {
            transform.position = new Vector3(transform.position.x, -4.1f, 0);
        }
        else if (transform.position.y > 4.1f)
        {
            transform.position = new Vector3(transform.position.x, 4.1f, 0);
        }

        if (transform.position.x < -8.25f)
        {
            transform.position = new Vector3(8.25f, transform.position.y, 0);
        }
        else if (transform.position.x > 8.25f)
        {
            transform.position = new Vector3(-8.25f, transform.position.y, 0);
        }

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.up    * Time.deltaTime * speed * verticalInput);

        
    }
}