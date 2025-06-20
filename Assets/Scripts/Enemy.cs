using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2.5f;
    [SerializeField] private PlayerController _player;
    [SerializeField] private AudioController _hitSounds;
    [SerializeField] AudioClip _deathClip;
    AudioSource _deathSound;

    //[SerializeField] private AudioManager _steps;

    private void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");
        _player = player.GetComponent<PlayerController>();
        _deathSound = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
    }

    private void EnemyMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime); // <- muove l'Enemy verso il Player tramite transform.position
        //_steps.EnemyStepsSound();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            _deathSound.clip = _deathClip;
            _deathSound.Play();
            Destroy(collision.gameObject);
        }

        if(collision.collider.CompareTag("Bullet"))
        {
            _hitSounds.ShootHitSounds();
            Destroy(collision.gameObject);
        }
    }
}
