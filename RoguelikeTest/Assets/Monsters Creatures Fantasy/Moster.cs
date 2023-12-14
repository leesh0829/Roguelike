using UnityEngine;

public class Moster : MonoBehaviour
{
    // 몬스터의 이동 속도
    public float speed = 5f;

    // 레이캐스트 거리
    public float raycastDistance = 1f;

    // 장애물을 나타내는 레이어 마스크
    public LayerMask obstacleLayer;

    // 플레이어의 위치를 저장하는 변수
    private Transform player;

    void Start()
    {
        // 플레이어의 위치를 찾아서 저장
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // 플레이어를 향해 이동하는 함수 호출
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        // 플레이어를 향하는 방향 벡터 계산
        Vector2 direction = (player.position - transform.position).normalized;

        // 플레이어를 향해 바라보도록 설정
        transform.LookAt(player);

        // Z 축 회전을 0으로 고정
        transform.eulerAngles = new Vector3(0, 0, 0);


        // 레이캐스트를 사용하여 장애물 감지
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, raycastDistance, obstacleLayer);

        if (hit.collider != null)
        {
            // 장애물이 감지되면 피해가는 방향 계산
            Vector2 avoidDirection = CalculateAvoidanceDirection(direction);
            transform.Translate(avoidDirection * speed * Time.deltaTime);
        }
        else
        {
            // 장애물이 없으면 플레이어를 향해 직진
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    // 피해가는 방향 계산하는 함수
    Vector2 CalculateAvoidanceDirection(Vector2 originalDirection)
    {
        // 현재 방향에서 90도 시계 방향으로 방향을 조정하여 간단한 회피
        return new Vector2(originalDirection.y, -originalDirection.x).normalized;
    }
}