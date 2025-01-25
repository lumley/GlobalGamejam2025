using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
    public Button KillerButton;
    public GameObject Target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KillerButton.onClick.AddListener(Kill);
    }

    private void OnDestroy()
    {
        KillerButton.onClick.RemoveAllListeners();
    }

    private void Kill()
    {
        Destroy(Target);
    }
}
