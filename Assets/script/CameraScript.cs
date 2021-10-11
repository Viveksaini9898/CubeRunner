using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform playerTransform;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var cameraPos = transform.position;
        cameraPos.z = playerTransform.position.z + offset;
        transform.position = cameraPos;

    }
}
