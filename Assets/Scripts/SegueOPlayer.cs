using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueOPlayer : MonoBehaviour
{

    Vector3 player = new Vector3(5, 0, 4);
    private Transform Target;
    public int speed = 8;


    void Start()
    {
        //aqui ele só é alterado para seguir o player no lugar do vilão
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
    }
}
