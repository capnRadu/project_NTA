using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    private float speed = 0.5f;

    private FixedJoystick fixedJoystick;
    private Rigidbody rb;

    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float zVal = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal, 0, zVal);
        rb.velocity = movement * speed;

        if (xVal != 0 && zVal != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.z, Mathf.Atan2(xVal, zVal) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }
}
