using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector3 lastMoveDir;

    private bool canDash = true;

    private void Update()
    {
        HandleMovement();
        HandleDash();
    }

    private void FixedUpdate()
    {
        if (GetComponent<CharacterStats>().heatlh == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void HandleMovement()
    {
        float speed = gameObject.GetComponent<CharacterStats>().speed;
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }

        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        lastMoveDir = moveDir;
        transform.position += moveDir * speed * Time.deltaTime;
    }

    private void HandleDash()
    {
        if (canDash == false)
        {
            return;
        }

        if (Input.GetMouseButtonDown(1))
        {
            float dashDistance = 2f;
            transform.position += lastMoveDir * dashDistance;
            canDash = false;
            StartCoroutine(dashCooldown());
        }
    }

    private IEnumerator dashCooldown()
    {
        yield return new WaitForSeconds(2f);
        canDash = true;
    }
}
