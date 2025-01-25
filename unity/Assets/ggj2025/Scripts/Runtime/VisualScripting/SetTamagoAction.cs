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
        SetLocalization(buttonA.GetComponentInChildren<LocalizeStringEvent>(), localizedStringA);
        SetLocalization(buttonB.GetComponentInChildren<LocalizeStringEvent>(), localizedStringB);
        SetLocalization(buttonC.GetComponentInChildren<LocalizeStringEvent>(), localizedStringC);
    }
    
    public static void SetLocalization(
        LocalizeStringEvent localizeStringEvent,
        ScriptableLocalizedString localizedString) {
        localizeStringEvent.StringReference = localizedString.LocalizedString;
    }
}