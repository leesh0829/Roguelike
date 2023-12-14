using UnityEngine;

public class Flymoster : MonoBehaviour
{
    // ������ �̵� �ӵ�
    public float speed = 5f;

    // ����ĳ��Ʈ �Ÿ�
    public float raycastDistance = 1f;

    // ��ֹ��� ��Ÿ���� ���̾� ����ũ
    public LayerMask obstacleLayer;

    // �÷��̾��� ��ġ�� �����ϴ� ����
    private Transform player;

    void Start()
    {
        // �÷��̾��� ��ġ�� ã�Ƽ� ����
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // �÷��̾ ���� �̵��ϴ� �Լ� ȣ��
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        // �÷��̾ ���ϴ� ���� ���� ���
        Vector2 direction = (player.position - transform.position).normalized;

        // �÷��̾ ���� �ٶ󺸵��� ����
        transform.LookAt(player);

        // Z �� ȸ���� 0���� ����
        transform.eulerAngles = new Vector3(0, 0, 0);
        
        // ��ֹ��� ������ �÷��̾ ���� ����
        transform.Translate(direction * speed * Time.deltaTime);
        
    }
}