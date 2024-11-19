using TMPro;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;//�������� ������
    [SerializeField] private TMP_Text _winText;//����� ����������
    [SerializeField] private GameObject[] _moveTriggers;
    [SerializeField] private ParticleSystem[] _winParticles;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)//��� ����� � ������� ����� �������, ���� ��������
    {
        if (other.gameObject.GetComponent<Player>() != null)
        {
            _winPanel.SetActive(true);
            _winText.text = PlayerPrefs.GetString("PlayerName") + " ������� �� " + Timer.Instance.TimerPublic.ToString("0.0" + " c��");

            Player.Instance.Speed = 0;
            _audioSource.Play();
            for (int i = 0; i < _moveTriggers.Length; i++)
            {
                _moveTriggers[i].SetActive(false);
            }

            for (int i = 0; i < _winParticles.Length; i++)
            {
                _winParticles[i].Play();
            }
        }
    }
}
