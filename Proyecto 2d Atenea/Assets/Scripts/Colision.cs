using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D colision){
        if(colision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(4);
        }
    }
}


