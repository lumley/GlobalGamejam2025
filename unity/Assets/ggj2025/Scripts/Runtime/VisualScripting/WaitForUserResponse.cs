using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WaitForUserResponse : Unit {
    [DoNotSerialize] public ControlInput Start = null!;
    [DoNotSerialize] public ControlOutput End1 = null!;
    [DoNotSerialize] public ControlOutput End2 = null!;
    [DoNotSerialize] public ControlOutput End3 = null!;

    [DoNotSerialize] public ValueInput _buttonA =  null!;
    [DoNotSerialize] public ValueInput _buttonB =  null!;
    [DoNotSerialize] public ValueInput _buttonC =  null!;
    
    protected override void Definition() {
        Start = ControlInputCoroutine(nameof(Start), LoadSceneCoroutine);
        End1 = ControlOutput(nameof(End1));
        End2 = ControlOutput(nameof(End2));
        End3 = ControlOutput(nameof(End3));
        _buttonA = ValueInput<Button>(nameof(_buttonA), null);
        _buttonB = ValueInput<Button>(nameof(_buttonB), null);
        _buttonC = ValueInput<Button>(nameof(_buttonC), null);
    }

    private IEnumerator LoadSceneCoroutine(Flow flow) {
        ControlOutput result = null;
        var buttonA = flow.GetValue<Button>(_buttonA);
        var buttonB = flow.GetValue<Button>(_buttonB);
        var buttonC = flow.GetValue<Button>(_buttonC);
        buttonA.onClick.AddListener(() => { result = End1; });
        buttonB.onClick.AddListener(() => { result = End2; });
        buttonC.onClick.AddListener(() => { result = End3; });
        while (result == null) {
            yield return new WaitForSeconds(0.1f);
        }
        buttonA.onClick.RemoveAllListeners();
        buttonB.onClick.RemoveAllListeners();
        buttonC.onClick.RemoveAllListeners();
        yield return result;
    }
}