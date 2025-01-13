using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_rotation : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(100 * Time.deltaTime, 100 * Time.deltaTime, 0);
    }
}
