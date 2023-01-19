using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour
{

    [Header("Movimenta��o")]
    [Space(20)]
    public float salto; //somente o pulo pq o personagem se manter� est�tico.
    public Rigidbody2D rgd2; //puxando o rigidbody para incrementar o salto

    void Start()
    {
        rgd2 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
    }

    public void Move()
    {
        //criando o salto do personagem para desviar dos objetos e tiros
        if (Input.GetMouseButtonDown(0))
        {
            rgd2.velocity = Vector2.up * salto;
            Debug.Log("Pulou");
        }
    }
}


