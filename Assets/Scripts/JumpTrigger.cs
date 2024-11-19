using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    private int _handsInTrigger;//������� ��� � ��������
    [SerializeField] private float _jumpForce;//���� ������
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)//���� ��� ���� ������ � �������, �� �������
    {
        if(Timer.Instance._isGameStarted)
        {
            if (other.gameObject.GetComponent<PlayerHand>() != null)
            {
                _handsInTrigger++;
                if (_handsInTrigger >= 2)
                {
                    Player.Instance.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * _jumpForce);
                    _handsInTrigger = 0;
                    _audioSource.Play();
                }
            }
        }
    }
}
