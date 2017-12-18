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

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.up    * Time.deltaTime * speed * verticalInput);

        
    }
}
