using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 0;
        int r = 0;
        try // ���ܰ� �߻��� ���ɼ��� �ִ� ��ɹ�
        {
            r = x / y;
            Debug.Log($"{x}/{y}={r}");
        }
        catch //try ���������ܰ� �߻��ϸ� catch���� ����
        {
            Debug.Log("���ܰ� �߻��߽��ϴ�");
        }
        finally//try������ ���ܰ� �߻��ϴ�, ���ϴ� ������� ����
        {
            Debug.Log("���α׷��� �����մϴ�");
        }
    }
}
