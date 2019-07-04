using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaItens : MonoBehaviour
{
    public float pontos = 0;
    private void OnTriggerEnter2D (Collider2D col)
    {
        Destroy(col.gameObject);
        pontos = +1;
    }
}
