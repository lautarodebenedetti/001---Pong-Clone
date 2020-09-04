using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2IA : MonoBehaviour
{
    public float movementSpeed;
    public GameObject ball;

    private void FixedUpdate()
    {
        if(Mathf.Abs(this.transform.position.y - this.ball.transform.position.y) > 10)
        {
            if(transform.position.y < this.ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0.1f) * movementSpeed;
            } else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -0.1f) * movementSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
