using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragnshoot : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;
    public TrajectoryLine tl;
    public Vector2 minpow;
    public Vector2 maxpow;
    Camera cam;
    public Vector2 force;
    Vector3 startpoint;
    Vector3 endpoint;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        tl = GetComponent<TrajectoryLine>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            startpoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startpoint.z = 15;
        }
        if(Input.GetMouseButton(0)){
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startpoint,currentPoint);
        }

        if(Input.GetMouseButtonUp(0)){
            endpoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endpoint.z = 15;

            force = new Vector2(Mathf.Clamp(startpoint.x - endpoint.x,minpow.x,maxpow.x),Mathf.Clamp(startpoint.y - endpoint.y,minpow.y,maxpow.y));
            rb.AddForce(force * power,ForceMode2D.Impulse);
            tl.endLine();
        }
        
    }
}
