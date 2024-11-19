using TMPro;
using UnityEngine;

public class Registration : MonoBehaviour
{
    [SerializeField] private TMP_InputField _registrationField;//поле, где мы ввели имя

    public void SaveName()//сохраняем имя
    {
        PlayerPrefs.SetString("PlayerName", _registrationField.text);
        PlayerPrefs.Save();
    }
}
