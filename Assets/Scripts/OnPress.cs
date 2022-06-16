using UnityEngine;
using BNG;

public class OnPress : MonoBehaviour
{
    InputBridge input;


    ToggleInterface toggle;


    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Awake()
    {
        input = InputBridge.Instance;
        toggle = GetComponent<ToggleInterface>();
    }
    void Start()
    {
        input.OnAbuttonPressed += ShowMenu;

    }

    public void ShowMenu()
    {
        toggle.Toggle();
    }
}
