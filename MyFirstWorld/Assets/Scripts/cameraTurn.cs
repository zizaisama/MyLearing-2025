using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTurn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private float xRotation = 0f;
    private float yRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * 100f * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * 100f * Time.deltaTime;

        // 摄像机上下旋转
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // 角色左右旋转
        yRotation += mouseX;

        // 应用旋转
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // 摄像机上下
        player.rotation = Quaternion.Euler(0f, yRotation, 0f); 
    }
}
