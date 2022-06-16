using TMPro;
using UnityEngine;
public class ChangeText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _description;
    [SerializeField]
    private string _text;

    void Start()
    {
        _description.text = _text;
    }
    public void Change(string newText)
    {
        _description.text = newText;
    }
}