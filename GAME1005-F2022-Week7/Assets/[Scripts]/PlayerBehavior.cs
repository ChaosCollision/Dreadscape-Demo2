using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float horizontalForce;
    public float verticalForce;

    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal") * horizontalForce;
        rigidbody2D.AddForce(Vector2.right * x);
        float y = Input.GetAxisRaw("Vertical") * verticalForce;
        rigidbody2D.AddForce(Vector2.up * y);
    }
}
