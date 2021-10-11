using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed = 100f;
    public float force = 1000f;
    public float minX, maxX;
    public Vector3 userAcceleration;



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;

        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, 0.0f);
            transform.position = transform.position + movement * speed * Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, force * Time.deltaTime);

    }
}
