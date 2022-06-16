using UnityEngine;

/// <summary>
/// Toggle canvas component
/// </summary>
public class ToggleInterface : MonoBehaviour
{
    [Tooltip("Sets canvas starting visibility")]
    public bool enableOnStart = false;
    private Canvas canvas = null;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    private void Start()
    {
        canvas.enabled = enableOnStart;
    }

    public  void Toggle()
    {
        bool isEnabled = !canvas.enabled;
        canvas.enabled = isEnabled;
    }

    public  void Disable()
    {
        canvas.enabled = false;
    }

    public  void Enable()
    {
        canvas.enabled = true;

    }
    public bool CanvasState()
    {
        return canvas.enabled;
    }
}
