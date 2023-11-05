using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour
{

    float moveSpeed = 20;
    float timer;
    int childCount;
    public float intervaloSpawn = 1.5f;

    void Start()
    {
        timer = 0;
        childCount = transform.childCount;
    }

    void Update()
    {
        if (timer < intervaloSpawn)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            moveSpeed += 1;
        }
        transform.position += (Vector3.left * moveSpeed)  * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "destroyer")
        {
            GameObject.Destroy(gameObject);
        }
    }

}
