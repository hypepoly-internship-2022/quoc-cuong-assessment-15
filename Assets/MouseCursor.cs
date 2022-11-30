using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{

    private Vector3 mousePosition;
    private Vector3 worldPosition;

    private void Start() 
    {

    }

    // Update is called once per frame
    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane + 4;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        this.transform.position = worldPosition;
    }
}
