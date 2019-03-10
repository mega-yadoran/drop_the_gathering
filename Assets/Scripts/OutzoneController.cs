using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutzoneController : MonoBehaviour {

    public GameObject gameController;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        gameController.GetComponent<GameController>().Damage();
    }
}
