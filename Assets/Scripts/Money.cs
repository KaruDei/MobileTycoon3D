using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMoney;
    public int _money = 0;

    private void Start()
    {
        UpdateMoney();
    }

    public void UpdateMoney()
    {
        _textMoney.text = "Δενεγ: " + _money;
    }
}
