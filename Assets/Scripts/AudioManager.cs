using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager: MonoBehaviour
{
    UnityEngine.AudioSource audioSource;
    [SerializeField] UnityEngine.AudioClip[] _shootSounds;
    [SerializeField] UnityEngine.AudioClip[] _hitSounds;
    //[SerializeField] AudioClip[] _playerStepsSounds;
    //[SerializeField] AudioClip[] _enemyStepsSounds;

    private void Awake()
    {
        audioSource = GetComponent<UnityEngine.AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void PlayerStepsSound()
    //{
    //    int randomIndex = Random.Range(0, _playerStepsSounds.Length);
    //    audioSource.clip = _playerStepsSounds[randomIndex];
    //    audioSource.Play();
    //}

    //public void EnemyStepsSound()
    //{
    //    int randomIndex = Random.Range(0, _enemyStepsSounds.Length);
    //    audioSource.clip = _enemyStepsSounds[randomIndex];
    //    audioSource.Play();
    //}

    public void ShootSounds()
    {
        int randomIndex = Random.Range(0, _shootSounds.Length);
        audioSource.clip = _shootSounds[randomIndex];
        audioSource.Play();
    }

    public void ShootHitSounds()
    {
        int randomIndex = Random.Range(0, _hitSounds.Length);
        audioSource.clip = _hitSounds[randomIndex];
        audioSource.Play();
    }
}
