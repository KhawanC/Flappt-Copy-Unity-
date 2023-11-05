using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnerScript : MonoBehaviour
{

    public new GameObject cano;
    private float intervaloSpawn = 1.5f;
    private float timer;
    private float distanciaCanoAleat = 10;

    void Start()
    {
        InstanciarCano();
    }

    void Update()
    {
        calcularInstanciaCano();

    }

    void InstanciarCano()
    {
        float pBaixo = transform.position.y - distanciaCanoAleat;
        float pAlto = transform.position.y + distanciaCanoAleat;

        Instantiate(cano, new Vector3(transform.position.x, Random.Range(pBaixo, pAlto), 0), transform.rotation);
        timer = 0;
    }

    void calcularInstanciaCano()
    {
        if (timer < intervaloSpawn)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (intervaloSpawn >= 0.9)
            {
                intervaloSpawn -= 0.05f;
            }

            InstanciarCano();
        }
    }
}
