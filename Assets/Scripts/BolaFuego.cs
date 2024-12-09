using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaFuego : MonoBehaviour
{
    [SerializeField] private float fuerza;
    [SerializeField] private int rebotes;

    Rigidbody2D rb;

    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * fuerza, ForceMode2D.Impulse);
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rebotes++;
        if (rebotes == 3)
        {
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            anim.SetTrigger("explosion");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
