using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;

    [SerializeField]
    private GameObject _laserPrefab;

    [SerializeField]
    private float _fireRate = 0.5f;


    private float _canFire = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        Movement();

        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (Time.time > _canFire)
            {
                Instantiate(_laserPrefab, transform.position + new Vector3(0f, 1.4f, 0f), Quaternion.identity);
                _canFire = Time.time + _fireRate;
            }

        }
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("horizontal");
        float verticalInput   = Input.GetAxis("vertical");

        transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalInput);
        transform.Translate(Vector3.up    * Time.deltaTime * _speed * verticalInput);

        if (transform.position.y > 0f)
        {
            transform.position = new Vector3(transform.position.x, 0f, 0);
        }
        else if (transform.position.y < -4.1f)
        {
            transform.position = new Vector3(transform.position.x, -4.1f, 0);
        }

        if (transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }
        else if (transform.position.x > 9.5f)
        {
            transform.position = new Vector3(-9.5f, transform.position.y, 0);
        }
    }



}
