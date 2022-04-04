using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    //variaveis para os vilões 
    public GameObject Vilan;
    public GameObject Vilan2;
    public GameObject Vilan3;
    public GameObject Vilan4;
    public GameObject Vilan5;


    public string actGoal;
    public Material check;
    public int lap;
    Rigidbody rb;

    // variavel publica para controlar a velociade do player e vector3 para direção
    public float speed = 5;
    Vector3 direction;
    private void Start()
    {
        //aqui diz que o resource vai carregar um material para trocar a cor do vilão ao colidir
        check = Resources.Load("check", typeof(Material)) as Material;
        rb = GetComponent<Rigidbody>();
        Vilan = GameObject.Find("Vilan");
        Vilan2 = GameObject.Find("Vilan2");
        Vilan3 = GameObject.Find("Vilan3");
        Vilan4 = GameObject.Find("Vilan4");
        Vilan5 = GameObject.Find("Vilan5");



        actGoal = "Vilan";
        lap = 1;
    }
    private void Update()
    {
        //player troca de direção ao colidir com um objeto villan
        switch (actGoal)
        {
            case "Vilan":
                direction = Vilan.transform.position - transform.position;
                direction.Normalize();
                break;
            case "Vilan2":
                direction = Vilan2.transform.position - transform.position;
                direction.Normalize();
                break;
            case "Vilan3":
                direction = Vilan3.transform.position - transform.position;
                direction.Normalize();
                break;
            case "Vilan4":
                direction = Vilan4.transform.position - transform.position;
                direction.Normalize();
                break;
            case "Vilan5":
                direction = Vilan5.transform.position - transform.position;
                direction.Normalize();
                break;
        }

    }
    //colisão quando o player colide com um objeto villan esse muda de cor 
    void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        switch (name)
        {
            case "Vilan":
                Vilan.GetComponent<Renderer>().material = check;
                actGoal = "Vilan2";
                break;
            case "Vilan2":
                Vilan2.GetComponent<Renderer>().material = check;
                actGoal = "Vilan3";
                break;
            case "Vilan3":
                Vilan3.GetComponent<Renderer>().material = check;
                actGoal = "Vilan4";
                break;
            case "Vilan4":
                if (lap == 1)
                {
                    Vilan4.GetComponent<Renderer>().material = check;
                    actGoal = "Vilan5";
                }
                else if (lap == 2)
                {
                    speed = 0;
                }
                break;
            case "Vilan5":
                Vilan5.GetComponent<Renderer>().material = check;
                actGoal = "Vilan4";
                lap = 2;


                break;
        }
    }

    private void FixedUpdate()
    {
        //velocidade personagem
        rb.velocity = direction * speed;
    }
}
