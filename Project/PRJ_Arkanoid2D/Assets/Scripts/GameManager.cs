using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] BallManager _ball;
    [SerializeField] PlayerController _player;
    [SerializeField] GameObject[] _lifes;
    [SerializeField] BlockManager[] _blocks;
    [SerializeField] GameObject _pausePanel, _winTMP, _loseTMP;
    [SerializeField] StartGame _start;
    [SerializeField] Button _playBtn;
    [SerializeField] GameObject _prefabPSCollision;
    [SerializeField] TextMeshProUGUI _pointsTMP;
    private int points = 0;

    public Image[] lifesImages;

    int _blocksToWin, _lifesCount;

    private void Start()
    {
        _blocksToWin = _blocks.Length;
        _lifesCount = _lifes.Length;

        ResetGame(false);

        _pausePanel.SetActive(true);
        _winTMP.SetActive(false);
        _loseTMP.SetActive(false);

        _start.enabled = false;
        _playBtn.interactable = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            points = 0;
            _pointsTMP.text = points + " : Points";
            ResetGame(false);

            _pausePanel.SetActive(true);
            _winTMP.SetActive(false);
            _loseTMP.SetActive(true);

            _start.enabled = false;
            _playBtn.interactable = true;
        }
    }

    private void EnableLifes(bool value)
    {
        for (int i = 0; i < _lifes.Length; i++)
        {
            _lifes[i].SetActive(value);
        }
    }
    private void EnableBlocks(bool value)
    {
        for (int i = 0; i < _blocks.Length; i++)
        {
            _blocks[i].gameObject.SetActive(value);
        }
    }

    private void ResetGame(bool value)
    {
        _ball.ResetBall();
        _player.ResetPlayer();

        _ball.gameObject.SetActive(value);
        _player.gameObject.SetActive(value);

        EnableLifes(value);
        EnableBlocks(value);

        _playBtn.interactable = true;
    }

    public void StartGame()
    {
        _blocksToWin = _blocks.Length;
        _lifesCount = _lifes.Length;

        ResetGame(true);

        _start.enabled = true;
        _pausePanel.SetActive(false);
        _winTMP.SetActive(false);
        _loseTMP.SetActive(false);
        _playBtn.interactable = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void CheckWin(BlockManager block, Vector2 collisionPos, Color color)
    {
        if (block.blockLives == 0)
        {
            block.gameObject.SetActive(false);
            _blocksToWin--;
            points += (block.blockID + 1);
            _pointsTMP.text = points + " : Points";
        }
        else
        {
            block.blockLives--;
        }

        ParticleSystem.MainModule ps = Instantiate(_prefabPSCollision, collisionPos, Quaternion.identity).GetComponent<ParticleSystem>().main;
        ps.startColor = color;

        if (_blocksToWin == 0)
        {
            ResetGame(false);

            _pausePanel.SetActive(true);
            _winTMP.SetActive(true);
            _loseTMP.SetActive(false);

            _start.enabled = false;
            _playBtn.interactable = true;
        }
    }

    public void CheckLose()
    {
        _lifesCount--;

        _ball.ResetBall();
        _player.ResetPlayer();

        _start.enabled = true;

        CreateExplosion(lifesImages[_lifesCount].transform.position);
        _lifes[_lifesCount].SetActive(false);

        if (_lifesCount == 0)
        {
            points = 0;
            _pointsTMP.text = points + " : Points";
            ResetGame(false);

            _pausePanel.SetActive(true);
            _winTMP.SetActive(false);
            _loseTMP.SetActive(true);

            _start.enabled = false;
            _playBtn.interactable = true;
        }
    }

    private void CreateExplosion(Vector2 _pos)
    {
        GameObject newExplosion = new("Explosion");
        newExplosion.transform.position = _pos;
        newExplosion.AddComponent<SpriteRenderer>();
        newExplosion.GetComponent<SpriteRenderer>().sortingOrder = 2;
        newExplosion.AddComponent<AnimControl>().InitAnim(newExplosion.GetComponent<SpriteRenderer>(), new List<Sprite>(Resources.LoadAll<Sprite>("Explosion")), 0.2f, AnimType.ONCE);
        Destroy(newExplosion, 2);
    }
}
