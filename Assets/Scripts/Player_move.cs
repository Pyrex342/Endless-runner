using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player_move : MonoBehaviour
{
    public float jumpforce;
    float score;

    [SerializeField] bool isGrounded = false;
    bool isAlive = true;
    Rigidbody2D rb;

    [SerializeField] TextMeshProUGUI scoreText;
    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                isGrounded = false;
            }
        }

        if(isAlive == true)
        {
            score += Time.deltaTime * 4;
            scoreText.text = "SCORE: " + score.ToString("F");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded= true;
            }
        }

        if (other.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            SceneManager.LoadScene(1);
        }
    }
} 
