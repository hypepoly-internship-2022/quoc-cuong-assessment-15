using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanET : MonoBehaviour
{
    [SerializeField] private GameObject done;

    private Rigidbody body;
    private int dirty;

    private void Start()
    {
        dirty = 6;
    }

    private void Update()
    {
        if(dirty == 0) 
        {
            done.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.tag == "Dirty")
        {
            dirty--;
            body = other.GetComponent<Rigidbody>();
            randomWaterForce(body);
            body.useGravity = true;
            other.tag = "Clean";
        }
    }

    private void randomWaterForce(Rigidbody body)
    {
        int ran = Random.Range(50, 60);
        body.AddForce(0, ran * 3.5f, -ran);
    }
}
