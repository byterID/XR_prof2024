using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer Instance;
    [SerializeField] private TMP_Text _timerText;//���� ��� ������ �������
    public bool _isGameStarted;//���������� ������ ������
    private float timer;//��� ������

    public float TimerPublic//��������
    {
        get => timer;
        set
        {
            timer = value;
            _timerText.text = value.ToString("0.0" + " c��");
        }
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void StartTimer()//�������� �����
    {
        _isGameStarted = true;
    }

    private void Update()//������ �����
    {
        if (_isGameStarted)
        {
            timer += Time.deltaTime;
        }
    }
}
