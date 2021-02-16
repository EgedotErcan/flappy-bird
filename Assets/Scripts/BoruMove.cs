using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruMove : MonoBehaviour
{
    public float speed;
    private float time= 6f;

    private void Start()
    {
        Destroy(gameObject, time);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
