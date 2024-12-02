using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float danho;

  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecibirDanho(float danho)
    {
        vida = danho;
        Debug.Log("");
    }
}
