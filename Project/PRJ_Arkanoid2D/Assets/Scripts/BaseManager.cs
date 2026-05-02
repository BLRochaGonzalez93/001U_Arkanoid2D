using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    [SerializeField] GameManager _gm;

    // Start is called before the first frame update
    void Awake()
    {
        _gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _gm.CheckLose();
    }
}
