using UnityEngine;
using UnityEngine.Localization;

public class SpeechBubble : MonoBehaviour
{
    public UnityEngine.Localization.Components.LocalizeStringEvent Event;
    public void setText(LocalizedString text)
    {
        Event.StringReference = text;
    }
}
