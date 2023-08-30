using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float speed;
    //public float timer;

    private float maxPositionPipesX = -10.58f;
    //private float maxTimer = 2.3f;

    void Update()
    {
        if(transform.position.x < maxPositionPipesX)
        {
            transform.position = RandomPipes();
        }

        transform.position += Vector3.left * speed * Time.deltaTime;
        //TODO Сделать рандомное ускорение и замедление блоков в пределах разумного (после косметикти!)
        //if (timer > maxTimer)
        //{
        //    transform.position = RandomPipes();
        //    timer = 0;
        //}
        //timer += Time.deltaTime;
        //transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private Vector3 RandomPipes()
    {
        float rand = Random.Range(-1.43f, 3.6f);
        return new Vector3(-3.9f, rand, 0);
    }
}
