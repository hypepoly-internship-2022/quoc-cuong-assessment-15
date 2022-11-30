using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanET : MonoBehaviour
{

    private Camera mainCamera;
    private Rigidbody body;

    private void Awake() 
    {
        mainCamera = Camera.main;    
    }

    private void FixedUpdate() 
    {
        blowAwayDirt(); 
    }

    private void blowAwayDirt()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.CompareTag("Dirty"))
            {
                body = hit.collider.GetComponent<Rigidbody>();
                randomWaterForce(body);
                body.useGravity = true;
                hit.collider.tag = "Clean";
            }
        }
    }

    private void randomWaterForce(Rigidbody body)
    {
        int ran = Random.Range(50, 60);
        body.AddForce(0, ran * 3.5f, -ran);
    }
}
