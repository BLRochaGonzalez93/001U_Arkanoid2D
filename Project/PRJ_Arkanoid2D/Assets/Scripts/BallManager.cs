using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rB;
    public float speed = 5;

    Vector2 _initPos;


    float _timer = 0f;
    float _timeToIncreaseSpeed = 2.5f;
    float _speedIncreaseAmount = 0.25f;

    private void Awake()
    {
        _initPos = transform.position;
        _rB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _timeToIncreaseSpeed)
        {
            speed += _speedIncreaseAmount;
            if(speed >= 15)
            {
                speed = 15;
            }
            _rB.linearVelocity = _rB.linearVelocity.normalized * speed;
            Debug.Log("Speed: " + speed);
            Debug.Log("Increase: " + _speedIncreaseAmount);
            Debug.Log("Velocity: " + _rB.linearVelocity);
            _timer = 0f;
        }
        if(_rB.linearVelocity.x == 0.00f)
        {
            _rB.linearVelocity.Set(_rB.linearVelocity.x + Random.Range(-0.2f, 0.2f), _rB.linearVelocity.y);
        }
        if(_rB.linearVelocity.y == 0.00f)
        {
            _rB.linearVelocity.Set(_rB.linearVelocity.x, _rB.linearVelocity.y + Random.Range(-0.2f, 0.2f));
        }
    }

    public void SetSpeed(Vector2 direction)
    {
        speed = 5f;
        _rB.linearVelocity = direction.normalized * speed;
    }


    public void ResetBall()
    {
        _rB.linearVelocity = Vector2.zero;
        transform.position = _initPos;
    }

}
