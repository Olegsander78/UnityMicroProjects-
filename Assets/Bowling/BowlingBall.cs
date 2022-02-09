using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public float ForwardForce;
    public float LeftBorder;
    public float RightBorder;
    public float MoveIncrement;
    public Rigidbody Rig;

    public void Bowl()
    {
        Rig.AddForce(transform.forward * ForwardForce, ForceMode.Impulse);
    }

    public void MoveLeft()
    {
        if (transform.position.x < LeftBorder)
        {
            transform.position += new Vector3(MoveIncrement, 0f, 0f);
        }
    }

    public void MoveRight()
    {
        if (transform.position.x > RightBorder)
        {
            transform.position += new Vector3(-MoveIncrement, 0f, 0f);
        }
    }
}
