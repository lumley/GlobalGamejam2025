using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class SetTamagoAction : MonoBehaviour {
    [UsedImplicitly] // Visual Scripting
    public static void SetLocalizationToButtons(
        Button buttonA,
        Button buttonB,
        Button buttonC,
        ScriptableLocalizedString localizedStringA,
        ScriptableLocalizedString localizedStringB,
        ScriptableLocalizedString localizedStringC) {
        SetLocalizationToButton(buttonA, localizedStringA);
        SetLocalizationToButton(buttonB, localizedStringB);
        SetLocalizationToButton(buttonC, localizedStringC);
    }
    
    [UsedImplicitly] // Visual Scripting
    public static void SetLocalizationToButton(
        Button button,
        ScriptableLocalizedString localizedString) {
        var localizeStringEvent = button.GetComponentInChildren<LocalizeStringEvent>();
        localizeStringEvent.StringReference = localizedString.LocalizedString;
    }
    
    public static void SetLocalization(
        LocalizeStringEvent localizeStringEvent,
        ScriptableLocalizedString localizedString) {
        localizeStringEvent.StringReference = localizedString.LocalizedString;
    }
}