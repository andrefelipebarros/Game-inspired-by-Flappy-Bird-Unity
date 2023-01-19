using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador_de_Balas : MonoBehaviour
{
    [Header("Objeto e local do Spawner")]

    public GameObject bullet; //modelo da bala
    public Transform bulletPos; // position da bala

    [Header("timer do spawn da bala")]
    public float timer; //o tempo para gerar a bala

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gerando um contador
        timer += Time.deltaTime;
        //time de 2segundos
        if(timer > 2)
        {
            timer = 0;
            shoot();
        }
    }

    private void shoot()
    {
        //gerar instantaneamente a bala na posição escolhida na hierarquia
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
