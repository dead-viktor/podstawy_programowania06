using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    [SerializeField] float VectorX;
    [SerializeField] float VectorY = 0;
    [SerializeField] float VectorZ;
    [SerializeField] float speed = 5;
    float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        PrintText();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PrintText ()
    {
        Debug.Log("Sterowanie: WASD");
    }

    void PlayerMovement()
    {
        VectorX = Input.GetAxis("Horizontal");
        VectorZ = Input.GetAxis("Vertical");
        transform.Translate(VectorX* Time.deltaTime* speed, VectorY * Time.deltaTime* speed, VectorZ * Time.deltaTime* speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coins")
        {
            score++;
            Debug.Log("Zebrane punkty:" + score);
        }

        if (collision.gameObject.tag == "Obstacles")
        {
            Destroy(gameObject);
        }

    }



}
