using UnityEngine;

public class Trap : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)//если игрок попадает в ловушку, он замедляется
    {
        if (other.gameObject.GetComponent<Player>() != null)
        {
            _animator.SetBool("isTouched", true);
            Player.Instance.Speed -= 1;
        }
    }
}
