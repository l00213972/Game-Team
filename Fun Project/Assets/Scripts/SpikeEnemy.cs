using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeEnemy : MonoBehaviour
{
    public float speed = 5f;

    private bool isMove;

    private void Update()
    {
        if (isMove)
        {
            // Move down
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            isMove = true;
    }
}
