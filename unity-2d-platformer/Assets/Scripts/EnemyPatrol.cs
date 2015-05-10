using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float patrolDistance = 3f;

    private Vector3 startPosition;
    private int direction = 1;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * moveSpeed * Time.deltaTime);

        float distanceTravelled = transform.position.x - startPosition.x;

        if (distanceTravelled > patrolDistance || distanceTravelled < -patrolDistance)
        {
            direction *= -1;
            transform.localScale = new Vector3(-direction, 1, 1);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.LoseLife();
        }
    }
}