using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Boss : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rgb2;
    public float velocidade;
    void Start()
    {
        //buscando componentes ao código
        GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        //Desenvolvendo o tiro

        Vector3 direction = player.transform.position - transform.position;

        rgb2.velocity = new Vector2(direction.x, direction.y).normalized * velocidade;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
