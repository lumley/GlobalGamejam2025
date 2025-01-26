using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public sealed class UICredits : MonoBehaviour {
    public float TransitionDuration = 0.5f;
    public Button CloseButton;
    public AudioMixer Mixer;
    public AudioMixerSnapshot DefaultSnapshot;
    public AudioMixerSnapshot CreditsSnapshot;

    private void Awake() {
        CloseButton.onClick.AddListener(()=> {
            gameObject.SetActive(false);
        });
    }

    private void OnEnable() => Mixer.TransitionToSnapshots(new []{DefaultSnapshot, CreditsSnapshot}, new []{0f, 1f}, TransitionDuration);
    private void OnDisable() => Mixer.TransitionToSnapshots(new []{DefaultSnapshot, CreditsSnapshot}, new []{1f, 0f}, TransitionDuration);
}
