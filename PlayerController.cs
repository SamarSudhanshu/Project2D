using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float jumpAmount = 1f;
    [SerializeField] float rotateAmount = 1f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
    }

    void Controls()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, rotateAmount * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -rotateAmount * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount * Time.deltaTime, ForceMode2D.Impulse);
        }
        
    }
}
