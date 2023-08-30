using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float maxY = 4.5f;
    public float minY = -4.5f;
    public float velosity;

    private Rigidbody2D _rb = new Rigidbody2D();

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO ����������� ����������� ������������ ��������� ����� � �����. �������� ����������� minY ��� ������� ������.
        //TODO ������� ����������� ��������� ???? 
        //����������� ����� ���� ��� ������ 
        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, minX, maxX), 
            Mathf.Clamp(transform.position.y, minY, maxY), 
            transform.position.z
            );
        //������ �������� ������ ����
        if (Input.GetMouseButton(0))
        {
            _rb.velocity = Vector2.up * velosity;
        }
    }
    //private void OnCollisionEnter2D(UnityEngine.Collision2D myCollision) 
    //{
    //    Debug.Log("������������ ���������");
    //    velosity = 0;
    //    //myCollision.rigidbody.bodyType = RigidbodyType2D.Kinematic;
    //}
}
