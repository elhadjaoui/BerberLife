
using UnityEngine;
using BNG;

/// <summary>
///   ShowMap the map
/// </summary>

public class ShowMap : MonoBehaviour
{
    InputBridge input;
    DisableAllUi disable;
    ToggleInterface toggle;
    void Awake()
    {
        input = InputBridge.Instance;
        toggle = GetComponent<ToggleInterface>();
    }
    void Start()
    {
        input.OnBbuttonPressed += showMap;
    }

    public void showMap()
    {
        toggle.Toggle();  
    }
  
}