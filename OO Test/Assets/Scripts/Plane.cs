using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    public float verticalSpeed;
    [SerializeField]
    private float upLimit = 5;
    [SerializeField]
    private float downLimit = 3;
    private float upSpeed;

    // Start is called before the first frame update
    void Start()
    {
        upSpeed = verticalSpeed;
    }

    protected override void Move()
    {
        if (transform.position.y > upLimit)
        {
            upSpeed = -verticalSpeed;
        }
        else if (transform.position.y < downLimit)
        {
            upSpeed = verticalSpeed;
        }
        transform.Translate(Vector3.up * upSpeed * Time.deltaTime);

        base.Move();
    }
}
