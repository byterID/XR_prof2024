using TMPro;
using UnityEngine;

public class KeyBoard : MonoBehaviour
{
    [SerializeField] private TMP_Text _inputFieldText;//���� ��� ����� ������

    public void TypeA()//���� �������
    {
        _inputFieldText.text += "A".ToString();
    }
    public void TypeB()
    {
        _inputFieldText.text += "�".ToString();
    }
    public void TypeV()
    {
        _inputFieldText.text += "�".ToString();
    }
}
