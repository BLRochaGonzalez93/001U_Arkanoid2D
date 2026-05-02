using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject _advice;
    [SerializeField] Transform _player;
    [SerializeField] BallManager _ball;

    private void Awake()
    {
        _advice.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _advice.gameObject.SetActive(true);
        _ball.transform.parent = _player;
    }

    private void OnDisable()
    {
        _advice.gameObject.SetActive(false);
        _ball.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ball.SetSpeed(new Vector2(1, 1));

            this.enabled = false;
        }
    }
}
