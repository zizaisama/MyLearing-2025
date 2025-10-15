using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class testScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public String myName;
    void Start()
    {
        Debug.Log("Hello,World!MyName is "+myName);
    }

    // Update is called once per frame
    public float speed = 0f;
    void Update()
    {   
        float moveZ = 0f;
        if (Input.GetKey(KeyCode.W)) moveZ += 1f;
        if (Input.GetKey(KeyCode.S)) moveZ -= 1f;

        float moveX = 0f;
        if (Input.GetKey(KeyCode.D)) moveX += 1f;
        if (Input.GetKey(KeyCode.A)) moveX -= 1f;

        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
