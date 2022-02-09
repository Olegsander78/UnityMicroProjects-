using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Color HitColor;
    public MeshRenderer Mr;
    
    private void OnCollisionEnter(Collision collision)
    {
        Mr.material.color = HitColor;
    }
}
