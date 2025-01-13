using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class coin_collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            StartCoroutine(MoveCoinTowardsPlayer(other.transform, transform, other.gameObject));
        }
    }

    IEnumerator MoveCoinTowardsPlayer(Transform coin, Transform player, GameObject coinObject)
    {
        float duration = 1f;
        float clock = 0f;
        float speed = 8f;
        Vector3 scaleChange = new Vector3(-1f * Time.deltaTime, -1f * Time.deltaTime, -1f * Time.deltaTime);

        while (clock < duration)
        {
            coin.position = Vector3.MoveTowards(coin.position, player.position, speed * Time.deltaTime);
            if (coin.localScale.x > 0 && coin.localScale.y > 0 && coin.localScale.z > 0)
            {
                coin.localScale += scaleChange;
            }

            clock += Time.deltaTime;
            yield return null;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coins")
        {
            Destroy(collision.gameObject);
        }
    }

}
