using UnityEngine;
using UnityEngine.UI;

public class InvokeButton : MonoBehaviour {
    public Button ThisButton;
    public Button OtherButton;

    private void OnValidate() {
        if (ThisButton == null) {
            ThisButton = GetComponent<Button>();    
        }
    }

    private void Start() {
        ThisButton?.onClick.AddListener(() => {
            OtherButton?.onClick.Invoke();
        });
    }
}
