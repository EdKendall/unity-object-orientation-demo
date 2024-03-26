using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float speed;
    private int year;
    public int Year
    {
        get { return year; }
        set
        {
            if (value >= 0)
            {
                year = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * 25);
    }
}
