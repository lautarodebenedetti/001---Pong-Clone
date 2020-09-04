using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject racketPlayer2;

    public void Start()
    {
        ChangePlayer2Controls();
    }

    private void ChangePlayer2Controls()
    {
        if (Configuration.ONE_PLAYER)
        {
            racketPlayer2.GetComponent<RacketPlayer2>().enabled = false;
            racketPlayer2.GetComponent<RacketPlayer2IA>().enabled = true;
        }
        else
        {
            racketPlayer2.GetComponent<RacketPlayer2>().enabled = true;
            racketPlayer2.GetComponent<RacketPlayer2IA>().enabled = false;
        }
    }
}
