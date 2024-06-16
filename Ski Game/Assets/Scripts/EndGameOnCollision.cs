﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameOnCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {
            EndGame();
        }
    }

    void EndGame()
    {

        SceneManager.LoadSceneAsync(1);

    }

}