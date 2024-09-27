using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Otto : MonoBehaviour
{

    private Rigidbody2D rb;
    private int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    private void movement()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector2 (hInput * speed, vInput * speed);
    }
}
