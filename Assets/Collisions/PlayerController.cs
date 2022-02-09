using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveForce;
    public Rigidbody Rig;

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");

        Rig.AddForce(Vector3.right * xInput * MoveForce);
    }
}
