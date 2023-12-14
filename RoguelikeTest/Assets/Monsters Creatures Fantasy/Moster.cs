using UnityEngine;

public class Moster : MonoBehaviour
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


        // ����ĳ��Ʈ�� ����Ͽ� ��ֹ� ����
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, raycastDistance, obstacleLayer);

        if (hit.collider != null)
        {
            // ��ֹ��� �����Ǹ� ���ذ��� ���� ���
            Vector2 avoidDirection = CalculateAvoidanceDirection(direction);
            transform.Translate(avoidDirection * speed * Time.deltaTime);
        }
        else
        {
            // ��ֹ��� ������ �÷��̾ ���� ����
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    // ���ذ��� ���� ����ϴ� �Լ�
    Vector2 CalculateAvoidanceDirection(Vector2 originalDirection)
    {
        // ���� ���⿡�� 90�� �ð� �������� ������ �����Ͽ� ������ ȸ��
        return new Vector2(originalDirection.y, -originalDirection.x).normalized;
    }
}