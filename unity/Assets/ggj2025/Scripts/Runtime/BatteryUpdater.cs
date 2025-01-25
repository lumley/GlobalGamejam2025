using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BatteryUpdater : MonoBehaviour {
    public string BatteryLevelVariableName = "BatteryLevel";
    public Image BatteryImage;
    public Color GoodColor;
    public Color BadColor;
        
    private void Update() {
        var batteryLevel = (int)Variables.Scene(gameObject.scene).Get(BatteryLevelVariableName);
        BatteryImage.fillAmount = batteryLevel / 100f;
        BatteryImage.color = batteryLevel > 20 ? GoodColor : BadColor;
    }
}
