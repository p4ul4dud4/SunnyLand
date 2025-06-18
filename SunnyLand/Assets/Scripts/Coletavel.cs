using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coletavel : MonoBehaviour
{
    private int pontos = 5;
    public TMP_Text texto_pontos;
    public ParticleSystem efeito;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo começou " + pontos + " pontos.");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Rodando");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) ;
        {
            pontos++;
            texto_pontos.text = "Pontos: " + pontos.ToString();
            collision.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
        }
    }
}
