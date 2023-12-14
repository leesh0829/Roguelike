using UnityEngine;

public class Flymoster : MonoBehaviour
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
        
        // 장애물이 없으면 플레이어를 향해 직진
        transform.Translate(direction * speed * Time.deltaTime);
        
    }
}