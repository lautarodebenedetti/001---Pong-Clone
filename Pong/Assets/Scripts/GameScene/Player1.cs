using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    public Text score;
    public float speed;
    
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(new Vector3(0, - speed,0));
            Debug.Log("Bajar");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(new Vector3(0, + speed, 0));
        }
    }
}
