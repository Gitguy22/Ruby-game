using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2.5f;

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + Time.deltaTime * speed;

        rigidbody2d.MovePosition(position);
    }
}
