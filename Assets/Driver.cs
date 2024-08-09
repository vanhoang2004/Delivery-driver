using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 0.01f;
    [SerializeField] float fastSpeed = 100f;


    void Start()
    {
       
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount); 
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollideEnter2D(Collider2D other)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "speedUp")
        {
            Debug.Log("speedup");
            moveSpeed = fastSpeed;
            Destroy(other.gameObject, 0.5f);
        }
        else if(other.tag == "slowDown")
        {
            Debug.Log("slowdown");
            moveSpeed = slowSpeed;
            Destroy(other.gameObject, 0.5f);
        }
    }
}
