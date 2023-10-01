using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject BtnPausa;
    [SerializeField] private GameObject PanelPausa;

    public void Pausa(){
        Time.timeScale = 0f;
        BtnPausa.SetActive(false);
        PanelPausa.SetActive(true);
    
    }
    public void Reanudar(){
        Time.timeScale = 1f;
        BtnPausa.SetActive(true);
        PanelPausa.SetActive(false);

    }



}
