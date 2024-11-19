using TMPro;
using UnityEngine;

public class KeyBoard : MonoBehaviour
{
    [SerializeField] private TMP_Text _inputFieldText;//поле для ввода текста

    public void TypeA()//ввод буковок
    {
        _inputFieldText.text += "A".ToString();
    }
    public void TypeB()
    {
        _inputFieldText.text += "Б".ToString();
    }
    public void TypeV()
    {
        _inputFieldText.text += "В".ToString();
    }
}
