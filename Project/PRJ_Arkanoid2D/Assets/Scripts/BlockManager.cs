using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public int blockID;
    public int blockLives;

    [SerializeField] GameManager _gm;
    SpriteRenderer _sRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        _gm = GameObject.FindObjectOfType<GameManager>();
        _sRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _gm.CheckWin(this, other.GetContact(0).point, _sRenderer.color);
    }
}
