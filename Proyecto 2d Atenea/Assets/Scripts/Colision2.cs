using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision2 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D colision){
        if(colision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(5);
        }
    }
}
