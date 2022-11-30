using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{

    [SerializeField] private GameObject deodorant;

    private Vector3 mousePosition;
    private Vector3 worldPosition;
    private Rigidbody bodySpray;

    private void Start() 
    {
    }

    // Update is called once per frame
    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane + 7;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        this.transform.position = new Vector3(worldPosition.x, worldPosition.y, worldPosition.z);
        deodorant.transform.position = new Vector3(worldPosition.x, worldPosition.y - 2.4f, worldPosition.z);
    }
}
