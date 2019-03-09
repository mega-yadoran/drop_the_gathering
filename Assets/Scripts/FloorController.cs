using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FloorController : MonoBehaviour
{
    public int force;

    private Rigidbody rb;
    private bool isMoving;

    void Start()
    {
        isMoving = false;
        rb = transform.GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        
    }

    public void Open()
    {
        if(!isMoving)
        {
            isMoving = true;
            transform.DORotate(
                new Vector3(90f, 0f, 0f),
                0.5f
            ).OnComplete(() =>
            {
                transform.DORotate(
                   new Vector3(0f, 0f, 0f),
                   1.0f
               ).OnComplete(()=>
               {
                   isMoving = false;
               });
            });

        }
    }
}
