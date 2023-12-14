public class AudioManager : MonoBehaviour
{
    public AudioSource exSource; 
    public AudioSource musicSource;
    public static AudioManager instance = null;
    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;

    void Awake() {
        //Check if there is already an instance of SoundManager
        if (instance == null)
        //if not, set it to this.
        instance = this;
//If instance aiready exists?
else if (instance != this)
            //Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
            Destroy(gameObject);
        //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameobject);
    }


    public void Playsingle(Audioclip clip) {
        //Set the clip of our efxsource audio source to the clip passed in as a parameter.
        efxSource.clip = clip;
        efxSource.Play();
    }

    public void RandomizeSfx(params AudioClip[] clips)
    {
        //Generate a random number between 0 and the length of our array of clips passed in.
        int randomIndex = Random.Range(0, clips.Length);
        //Choose a random pitch to play back our clip at between our high and low pitch ranges.
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
// Set the pitch of the audio source to the randomly chosen pitch.
efxSource.pitch = randomPitch;
         // Set the clip to the clip at our randomly chosen index.
        efxSource.clips = clips[randomIndex];
        //Play the clip.
        efxSource.Play();
    }
}