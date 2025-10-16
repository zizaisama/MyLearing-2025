using System;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public String myName;
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 5f;
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Mouse X");

        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;

        if(movement.magnitude>1) movement = movement.normalized;

        transform.Translate(movement);
    }
    void FixedUpdate()
    {

    }
}
