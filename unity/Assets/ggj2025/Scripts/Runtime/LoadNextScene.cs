using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] private SceneInput MainSceneInput;
    [SerializeField] private InputActionReference MyInputActionReference;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        MyInputActionReference.action.performed += OnClick;
    }

    void OnDisable()
    {
        MyInputActionReference.action.performed -= OnClick;
    }
    // Update is called once per frame
    void Update()
    {

    }
    
    void OnClick(InputAction.CallbackContext _)
    {
        SceneManager.LoadScene(MainSceneInput.SceneIndex);
    }
}
[Serializable]
public class SceneInput 
 {
    public int SceneIndex;

}