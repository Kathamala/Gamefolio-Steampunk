using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    float horizontal;
    float vertical;
    private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = GetComponent<CharacterStats>().speed;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime);

        if (GetComponent<CharacterStats>().heatlh == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
