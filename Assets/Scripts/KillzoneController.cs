using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillzoneController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
    }
}
