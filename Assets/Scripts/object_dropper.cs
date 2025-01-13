using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_dropper : MonoBehaviour
{
    [SerializeField] float timetoDrop = 3f;

    void Update()
    {
        if (Time.time > timetoDrop)
        {
            //GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }

    }
}
