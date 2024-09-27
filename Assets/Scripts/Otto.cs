using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Otto : MonoBehaviour
{
    doorManager d742act;
    private Rigidbody2D rb;
    private int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        d742act = GameObject.FindGameObjectWithTag("Aula742").GetComponent<doorManager>();
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Atun"))
        {
            d742act.d742in = true;
        }
    }
}
