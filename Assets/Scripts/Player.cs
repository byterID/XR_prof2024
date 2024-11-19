using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public float Speed;//�������� ������

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()//����� �������� ���� �� ����� �������� ������ � ��������. �������� ��������� ������
    {
        transform.position += new Vector3(0, 0, -Speed * Time.deltaTime);
        if (Speed <= 0)
        {
            Speed = 0;
        }
        Speed -= Time.deltaTime;
    }
}
