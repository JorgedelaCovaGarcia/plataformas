using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : MonoBehaviour
{
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    [SerializeField] private float velocidad;
    [SerializeField] private float danho;
    [SerializeField] private float vida;
    private Transform destinoActual;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //Marco como destino actual el puntoB
        destinoActual = puntoB;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Nuestra posicion se actualiza por cada frame para dirigirse a su destino actual.
        transform.position = Vector3.MoveTowards(transform.position, destinoActual.position, 5 * Time.deltaTime);
      

        if (transform.position == puntoA.position)
        {
            destinoActual = puntoB;
            spriteRenderer.flipX = false;
            
        }
        if ( transform.position == puntoB.position)
        {
            destinoActual = puntoA;
            spriteRenderer.flipX = true;
        }

    }

    void Recibirdanho(float danho)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player>().RecibirDanho(danho);
        }
    }

}
