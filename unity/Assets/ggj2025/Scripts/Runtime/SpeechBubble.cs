using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Localization;

public class SpeechBubble : MonoBehaviour {
    public UnityEngine.Localization.Components.LocalizeStringEvent Event;

    public void SetText(LocalizedString text) {
        Event.StringReference = text;
    }
    
    [UsedImplicitly] // Visual scripting
    public void SetText(ScriptableLocalizedString text) {
        gameObject.SetActive(true);
        Event.StringReference = text.LocalizedString;
    }
}
