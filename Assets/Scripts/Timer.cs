using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer Instance;
    [SerializeField] private TMP_Text _timerText;//поле для вывода таймера
    public bool _isGameStarted;//переменная начала забега
    private float timer;//сам таймер

    public float TimerPublic//обсервер
    {
        get => timer;
        set
        {
            timer = value;
            _timerText.text = value.ToString("0.0" + " cек");
        }
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void StartTimer()//начинаем забег
    {
        _isGameStarted = true;
    }

    private void Update()//отсчет пошел
    {
        if (_isGameStarted)
        {
            timer += Time.deltaTime;
        }
    }
}
