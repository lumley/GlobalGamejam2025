using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelinePlayer : MonoBehaviour {
    public PlayableDirector[] Directors;

    private void OnValidate() {
        Directors = GetComponentsInChildren<PlayableDirector>(true);
    }

    [UsedImplicitly] // Visual Scripting
    public void PlayTimeline(TimelineAsset timeline) {
        foreach (var director in Directors) {
            director.gameObject.SetActive(false);
        }
        foreach (var director in Directors) {
            director.gameObject.SetActive(director.playableAsset == timeline);
            director.Play();
        }
    }
}
