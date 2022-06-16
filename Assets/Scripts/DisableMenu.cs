using BNG;
using UnityEngine;

public class DisableMenu : MonoBehaviour
{
    private Canvas canvas = null;

    InputBridge input;
    private void Awake()
    {
        input = InputBridge.Instance;
        canvas = GetComponent<Canvas>();
    }
    void Start()
    {
        input.OnLeftThumbStickPressed += DisableAll;
        input.OnBbuttonPressed += DisableAll;
    }

    void DisableAll()
    {
        canvas.enabled = false;
    }

}
