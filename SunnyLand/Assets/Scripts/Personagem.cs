using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    private string nome = "Bento";
    public int vida = 3;
    private bool isDead = false;
    public float velocidade = 1.2f;
    private Rigidbody2D rb;
    //public float novaGravidade = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá eu sou\n" + nome + "Vamos iniciar com\n" + vida + " vidas");
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 9.8f;
      //rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
