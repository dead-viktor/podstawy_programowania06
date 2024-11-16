using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_collision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
