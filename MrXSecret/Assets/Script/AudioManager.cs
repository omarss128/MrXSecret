using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip Background;
    public AudioClip death;
    public AudioClip checkpoint;
    public AudioClip scenetransition;
    public AudioClip level2;
    
    private void start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }

}
