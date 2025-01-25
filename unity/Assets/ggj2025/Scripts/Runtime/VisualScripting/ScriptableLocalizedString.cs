using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "ScriptableLocalizedString", menuName = "ScriptableObjects/ScriptableLocalizedString", order = 1)]
public sealed class ScriptableLocalizedString : ScriptableObject {
    public LocalizedString LocalizedString;
}