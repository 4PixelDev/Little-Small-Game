using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevelPoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MainMenu.instance.LoadNextScene();  // load next scene or level on collosion.

        }
    }
}
