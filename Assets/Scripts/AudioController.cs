using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController: MonoBehaviour
{
    AudioSource bgmAudioSource;
    AudioSource shootAudioSource;
    AudioSource hitAudioSource;
    [SerializeField] private AudioClip _bgmClip;
    [SerializeField] private AudioClip[] _shootClips;
    [SerializeField] private AudioClip[] _hitClips;
    //[SerializeField] AudioClip[] _playerStepsSounds;
    //[SerializeField] AudioClip[] _enemyStepsSounds;

    private void Awake()
    {
        bgmAudioSource = GetComponent<AudioSource>();
        shootAudioSource = GetComponent<AudioSource>();
        hitAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        bgmAudioSource.clip = _bgmClip;
        bgmAudioSource.Play();
        bgmAudioSource.loop = true;
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
        int randomIndex = Random.Range(0, _shootClips.Length);
        shootAudioSource.clip = _shootClips[randomIndex];
        shootAudioSource.Play();
    }

    public void ShootHitSounds()
    {
        int randomIndex = Random.Range(0, _hitClips.Length);
        hitAudioSource.clip = _hitClips[randomIndex];
        hitAudioSource.Play();
    }
}
