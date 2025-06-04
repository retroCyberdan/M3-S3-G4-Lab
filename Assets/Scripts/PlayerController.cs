using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] Rigidbody2D _rb;
    //[SerializeField] private AudioManager _steps;

    float h;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal"); // <- acquisisco gli input in Update
        v = Input.GetAxis("Vertical");
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {        
        if(h != 0 || v != 0) // <- gestisco la fisica in FixedUpdate
        {
            Vector2 dir = new Vector2(h, v); // <- creo un vettore direzione

            float length = dir.magnitude; // <- calcolo la sua lunghezza

            if(length > 1)
            {
                dir /= length; // <- normalizzo il vettore se la lunghezza � > di 1
                //dir.Normalize(); // <- posso farlo anche tramite metodo o in fase di dichiarazione del vettore tramite ".Normalized"
            }

            _rb.MovePosition(_rb.position + dir * (_speed * Time.deltaTime)); // <- eseguo il movimento tramite Rigidbody2D

            //_steps.PlayerStepsSound();
        }
    }
}
