using UnityEngine;
using BNG;

public class OnPress : MonoBehaviour
{
    InputBridge input;


    ToggleInterface toggle;
    bool isToggle = true;
    bool resume = true;

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
        Debug.Log("DFADFA");
          toggle.Toggle();
        // if (input.AButton)
        // {
        //     if(!toggle.CanvasState())
        //         toggle.Toggle();
        // }
        // else if (!input.AButton && toggle.CanvasState())
        // {
        //         toggle.Toggle();
        // }   
    }
}
