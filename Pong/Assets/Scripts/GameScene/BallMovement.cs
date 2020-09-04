using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public float extraSpeedPerHit;
    public float speedLimit;

    int hitCounter = 0;

    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    void PositionBall(bool isStartedPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (isStartedPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        } else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }

    public IEnumerator StartBall(bool isStartedPlayer1 = true)
    {
        this.PositionBall(isStartedPlayer1);
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartedPlayer1)
        {
            this.MoveBall(new Vector2(-1, 0));
        } else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.speed + this.hitCounter * this.extraSpeedPerHit;
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter()
    {
        if(this.hitCounter * this.extraSpeedPerHit <= this.speedLimit)
        {
            this.hitCounter++;
        }
    }
}
