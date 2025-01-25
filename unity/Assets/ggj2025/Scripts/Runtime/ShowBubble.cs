using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class ShowBubble : MonoBehaviour
{
    public SpeechBubble BubblePrefab;
    public Button SpawnButton;
    public LocalizedString text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnButton.onClick.AddListener(GetSpawnBubblePrefab);
    }

    private void GetSpawnBubblePrefab()
    {
        var instance = Instantiate(BubblePrefab);
        instance.setText(text);
    }
 }
