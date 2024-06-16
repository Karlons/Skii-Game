using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float boostSpeed = 10f;
    public float boostDuration = 2f;

    private float currentSpeed;
    private float boostTimer;
    private bool boostActive;

    void Start()
    {
        currentSpeed = playerSpeed;
        boostTimer = 0f;
        boostActive = false;
    }

    void Update()
    {
        HandleMovement();
        HandleBoost();
    }

    void HandleMovement()
    {
        float moveDirection = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            moveDirection = 1.5f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection = -1.5f;
        }

        // Movement vector: move left/right and downwards
        Vector3 movement = new Vector3(moveDirection, 0, 1) * currentSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    void HandleBoost()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !boostActive)
        {
            boostActive = true;
            currentSpeed += boostSpeed;
            boostTimer = boostDuration;
        }

        if (boostActive)
        {
            boostTimer -= Time.deltaTime;

            if (boostTimer <= 0)
            {
                boostActive = false;
                currentSpeed = playerSpeed;
            }
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Flag")
        {
            ScoreManager.scoreCount += 1;
        }
    }

}