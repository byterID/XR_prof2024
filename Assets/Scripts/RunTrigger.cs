using UnityEngine;

public class RunTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//���� � ������� ������ ���� ������ �������� �������������
    {
        if (Timer.Instance._isGameStarted)
        {
            if (other.gameObject.GetComponent<PlayerHand>() != null)
            {
                Player.Instance.Speed += 0.7f;
            }
        }
    }
}
