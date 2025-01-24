using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] private SceneInput MainSceneInput;
    [SerializeField] private Button StartButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        StartButton.onClick.AddListener(OnClick);
    }

    void OnDisable()
    {
        StartButton.onClick.RemoveListener(OnClick);

    }  
    void OnClick()
    {
        SceneManager.LoadScene(MainSceneInput.SceneIndex);
    }
}
[Serializable]
public class SceneInput 
 {
    public int SceneIndex;

}