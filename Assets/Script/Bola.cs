using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    //variaveis
    public float speed;
    



    // Start is called before the first frame update
    void Start()
    {

        
        //Operador ternário (SE eu sortear um numero entre 0 e 2/ Se esse numero for = 0, recebe -1. Caso Contrário = 1
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        //getcomponent
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedX * speed, speedY * speed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
