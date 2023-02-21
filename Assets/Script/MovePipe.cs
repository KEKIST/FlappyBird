using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2;
    [SerializeField] private float deadZone = -5;

    
    private void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x <= deadZone)
        {
            Destroy(gameObject);

        }
    }
}
