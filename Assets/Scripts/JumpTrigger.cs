using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    private int _handsInTrigger;//счетчик рук в триггере
    [SerializeField] private float _jumpForce;//сила прыжка
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)//если обе руки попали в триггер, мы прыгаем
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
