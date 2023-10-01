using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaCambioNivel : MonoBehaviour
{
    public int source;
    public int destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);

        if (SceneManager.GetActiveScene().buildIndex == source) {
            SceneManager.LoadScene(destination);
        }
        else{
            SceneManager.LoadScene(source);
        }

    }
}
