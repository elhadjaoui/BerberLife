using UnityEngine;
using BNG;

class DisableAllUi : MonoBehaviour
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
        input.OnAbuttonPressed += DisableAll;
    }

    void DisableAll()
    {
        canvas.enabled = false;
    }

}