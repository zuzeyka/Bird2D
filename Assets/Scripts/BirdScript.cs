using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float forceFactor = 300f;
    private float continualForceFactor = 1000f;
    private float fillAmount = 30f;
    private float currentfillAmount = 30f;
    private float timer = 0f;
    private float counterOfTimer = 0f;
    private int score = 0;

    public GameObject manager;

    void Start()
    {
        GameObject.Find("Score").GetComponent<TMP_Text>().text = score.ToString();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        counterOfTimer += Time.deltaTime;


        if (timer > fillAmount)
        {
            Debug.Log("FILL AMOUNT: " + currentfillAmount);
        }
        else if(counterOfTimer >= 1f)
        {
            currentfillAmount--;
            counterOfTimer = 0f;    
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * forceFactor * Time.timeScale);
        }
        else if (Input.GetKey(KeyCode.W) && !manager.GetComponent<GameState>().isWKeyEnable)
        {

            rb.AddForce(Vector2.up * continualForceFactor * Time.deltaTime);
        }
        Debug.Log(manager.GetComponent<GameState>().isWKeyEnable);
        Debug.Log(manager.GetComponent<GameState>().foodState);
        Debug.Log(manager.GetComponent<GameState>().pipeState );

        Debug.Log("FILL AMOUNT: " + currentfillAmount);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pipe")
        {
            SceneManager.LoadScene("FlappyBird");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Pipe")
        {
            SceneManager.LoadScene("FlappyBird");
        }
        else if(collision.gameObject.name == "ScoreCollider")
        {
            score++;
            GameObject.Find("Score").GetComponent<TMP_Text>().text = score.ToString();
        }
    }
}
