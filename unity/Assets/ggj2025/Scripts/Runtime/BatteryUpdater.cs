using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BatteryUpdater : MonoBehaviour {
    public string BatteryLevelVariableName = "BatteryLevel";
    public Image BatteryImage;
    public Sprite[] Sprites;

    private void Update() {
        var batteryLevel = (int)Variables.Scene(gameObject.scene).Get(BatteryLevelVariableName);
        var batteryLevelNormalized = batteryLevel / 100.0f;
        var batterySpriteIndex = Mathf.FloorToInt(batteryLevelNormalized * (Sprites.Length - 1));
        BatteryImage.sprite = Sprites[Mathf.Clamp(batterySpriteIndex, 0, Sprites.Length - 1)];
    }
}
