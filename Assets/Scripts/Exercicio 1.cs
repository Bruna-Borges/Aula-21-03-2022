using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{

    Vector3 player = new Vector3(5, 0, 4);
    public float speed = 0.1f;
   

    void Start()
    {
        
    }

 
    void Update()
    {

        this.transform.Translate(player.normalized * speed * Time.deltaTime);
    }
}
