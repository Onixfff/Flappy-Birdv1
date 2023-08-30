using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float maxY = 4.5f;
    public float minY = -4.5f;
    public float velosity;
    public Vector3 startPoint = new Vector3(-1.43f, 0, 0); 

    private Rigidbody2D _rb = new Rigidbody2D();

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO Проработать возможность передвижение персонажа вперёд и назад. Изменить ограничение minY или удалить вообще.
        //TODO Сделать возможность ускорения ???? 
        //Ограничение рамок игры для птички 
        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, minX, maxX), 
            Mathf.Clamp(transform.position.y, minY, maxY), 
            transform.position.z
            );
        //Подьём нажатием кнопки мыши
        if (Input.GetMouseButton(0))
        {
            _rb.velocity = Vector2.up * velosity;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
            //transform.position = new Vector3(-1.43f, 0, 0);
            //_rb.velocity = Vector2.zero;
        }
        else if (other.gameObject.tag == "Score")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
    //private void OnCollisionEnter2D(UnityEngine.Collision2D myCollision)
    //{
    //    Debug.Log("Столкновение произошло");
    //    velosity = 0;
    //    myCollision.rigidbody.bodyType = RigidbodyType2D.Kinematic;
    //}
}
