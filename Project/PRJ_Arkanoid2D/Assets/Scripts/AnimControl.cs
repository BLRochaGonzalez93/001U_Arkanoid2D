using System.Collections.Generic;
using UnityEngine;

public enum AnimType { ONCE, LOOP }

public class AnimControl : MonoBehaviour
{
    private SpriteRenderer rend;
    private List<Sprite> animationSprites;
    private float animationSpeed, animationRate;
    private int currentSprite;

    private AnimType aType;

    public void InitAnim(SpriteRenderer _rend, List<Sprite> _anim, float _speed, AnimType _type)
    {
        rend = _rend;
        animationSprites = _anim;
        animationSpeed = _speed;
        currentSprite = 0;
        aType = _type;
    }

    // Update is called once per frame
    void Update()
    {
        animationRate += Time.deltaTime;
        if (animationRate >= animationSpeed)
        {
            rend.sprite = animationSprites[currentSprite];
            currentSprite++;
            if (currentSprite >= animationSprites.Count)
            {
                if (aType == AnimType.LOOP)
                {
                    currentSprite = 0;
                }
                else
                {
                    Destroy(gameObject);
                }
            }
            animationRate = 0;
        }
    }
}
