using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //direcionando o player
    Vector3 player = new Vector3 (5, 0, 4);

    //Um alvo para o inimigo, que o player vai ir até
    private Transform Target;

    //Velocidade do player
    public int speed = 5;


    void Start()
    {
       // aqui o player vai encontrar um objeto que tenha a tag "Vilan" na cena no caso o vilão em verde.
        Target = GameObject.FindGameObjectWithTag("Vilan").GetComponent<Transform>();
    }                                                   // aqui o target quer pegar o transform que esta com a tag vilan  

    void Update()
    {
        //Aqui estamos fazendo o player se deslocar até o inimigo
        transform.position = Vector3.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
    }
}
