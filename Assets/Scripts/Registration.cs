using TMPro;
using UnityEngine;

public class Registration : MonoBehaviour
{
    [SerializeField] private TMP_InputField _registrationField;//����, ��� �� ����� ���

    public void SaveName()//��������� ���
    {
        PlayerPrefs.SetString("PlayerName", _registrationField.text);
        PlayerPrefs.Save();
    }
}
