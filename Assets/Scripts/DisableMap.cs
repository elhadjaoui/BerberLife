using UnityEngine;
using BNG;
public class DisableMap : MonoBehaviour
{
    // Start is called before the first frame update
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
        input.OnLeftThumbStickPressed += DisableAll;
    }

    void DisableAll()
    {
        canvas.enabled = false;
    }
}
