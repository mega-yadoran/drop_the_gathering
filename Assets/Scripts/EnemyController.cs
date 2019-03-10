using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float v;

    private Rigidbody rb;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = v * Random.Range(0.8f, 3f);
        rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = Vector3.forward * speed;
    }
}
