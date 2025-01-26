using UnityEngine;
using UnityEngine.Audio;

public sealed class AudioMixerSnapshotTransition : MonoBehaviour {
    public float TransitionDuration = 0.5f;
    public AudioMixer AudioMixer;
    public AudioMixerSnapshot DefaultSnapshot;
    public AudioMixerSnapshot TransitionSnapshot;
    
    private void Start() {
        AudioMixer.TransitionToSnapshots(new[] {DefaultSnapshot, TransitionSnapshot}, new[] {0f, 1f}, TransitionDuration);
    }
}
