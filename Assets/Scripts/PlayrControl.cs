using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrControl : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,0f, speed*Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
