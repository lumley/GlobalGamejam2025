using Codice.CM.Common;
using UnityEditor.Localization;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LanguageChanger : MonoBehaviour
{
    public int ENG = 0;
    public int ESP = 1;
    [SerializeField] private Button ENGButton;
    [SerializeField] private Button ESPButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnEnable()
    {
        ESPButton.onClick.AddListener(() => SwitchLanguage(1));
        ENGButton.onClick.AddListener(() => SwitchLanguage(0));
    }

    void OnDisable()
    {
        ESPButton.onClick.RemoveAllListeners();
        ENGButton.onClick.RemoveAllListeners();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchLanguage(int index)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
}
