using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 5.5f;
    [SerializeField] ParticleSystem _psCollision;
    float limitPlayerX = 7.3f;
    Vector2 _initPos;

    private void Awake()
    {
        _initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion = transform.position;
        posicion.x += Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime;

        if (posicion.x < -limitPlayerX)
        {
            posicion.x = -limitPlayerX;
        }

        if (posicion.x > limitPlayerX)
        {
            posicion.x = limitPlayerX;
        }

        transform.position = posicion;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _psCollision.transform.position = new Vector3(other.GetContact(0).point.x, other.GetContact(0).point.y, 0);
        _psCollision.gameObject.SetActive(true);
    }

    public void ResetPlayer()
    {
        transform.position = _initPos;
    }
}
