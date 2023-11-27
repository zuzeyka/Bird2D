using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MovementCircle : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;
    public TMP_Text spaceText;
    public TMP_Text aText;
    public TMP_Text dText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        Moving();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 250);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            spaceText.color = Color.red;    
        }
        else
        {
            spaceText.color = Color.white;
        }
    }
    private void Moving()
    {
        if(Input.GetKey(KeyCode.D)) 
        {
            rb.AddForce(Vector2.right * speed);
            dText.color = Color.red;
        }
        else
        {
            dText.color = Color.white;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed);
            aText.color = Color.red;

        }
        else
        {
            aText.color = Color.white;
        }
    }
}
