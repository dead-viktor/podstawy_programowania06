using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulder_collision : MonoBehaviour
{
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            other.gameObject.SetActive(true);
            Debug.Log("pociski");
        }
    }
}
