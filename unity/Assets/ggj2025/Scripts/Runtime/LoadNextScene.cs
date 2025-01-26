using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNextScene : MonoBehaviour {
    [SerializeField] private SceneInput MainSceneInput;
    [SerializeField] private Button StartButton;
    public bool ChangeOnStart = false;

    private void Start() {
        if (ChangeOnStart) {
            SceneManager.LoadScene(MainSceneInput.SceneIndex);
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable() {
        StartButton?.onClick.AddListener(OnClick);
    }

    private void OnDisable() {
        StartButton?.onClick.RemoveListener(OnClick);

    }
    
    private void OnClick() {
        SceneManager.LoadScene(MainSceneInput.SceneIndex);
    }
}

[Serializable]
public class SceneInput 
 {
    public int SceneIndex;

}