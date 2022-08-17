using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseCoordinatePixles = Input.mousePosition;
        // game coordnates
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(mouseCoordinatePixles);
        // direction from game object to mouse
        Vector2 direction = mousePosition - rb.position;
        // make the vector length equal to one
        direction.Normalize();
        rb.velocity = direction * speed;

    }
}
