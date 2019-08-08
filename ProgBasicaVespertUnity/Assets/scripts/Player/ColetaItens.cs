using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaItens : MonoBehaviour
{
    int pontos = 0;
    public Text placar; 

    private void OnTriggerEnter2D (Collider2D col)
    {
        Destroy(col.gameObject);
        pontos = pontos + 1;
        placar.text = "Pontos:"+pontos;   
    }
}
