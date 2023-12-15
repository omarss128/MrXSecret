using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip death;
    public AudioClip checkpoint;
    public AudioClip scenetransition;
    public AudioClip level2;
    
    private void start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

}
