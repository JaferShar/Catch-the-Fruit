using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Scroller : MonoBehaviour
{
    public SpriteRenderer background;
    public float speed;
    private Vector3 startPosition;
    private float eraseOffset = -15f;
    void Start()
    {
        startPosition = new Vector3(transform.position.x, 24.2f, 0);
    }
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < eraseOffset)
        {
            transform.position = startPosition;
        }
    }
}
