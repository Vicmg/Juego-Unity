using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShipEspace : MonoBehaviour
{
    public float speed = 10f;

    float roll;
    float pitch;
    float yaw;

  
    void Update()
    {
        roll = Input.GetAxisRaw("Horizontal");
        pitch = Input.GetAxisRaw("Vertical");

        transform.Rotate(Vector3.back * roll * 100f * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.back * pitch * 100f * Time.deltaTime, Space.Self);

        if (Input.GetKey("space")) transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
}
