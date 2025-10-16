using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothspeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {
        Vector3 cameraPosition = target.position + target.transform.rotation*offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, cameraPosition, smoothspeed * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
