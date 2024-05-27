using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _comTransform;
    private SpriteRenderer _comSpriteRenderer;
    public float speed;
    public float xDirection;
    public float yDirection;
    void Awake()
    {
        _comTransform = GetComponent<Transform>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _comTransform.position = new Vector2(_comTransform.position.x + speed * xDirection * Time.deltaTime, _comTransform.position.y + speed * yDirection * Time.deltaTime);
        if (_comTransform.position.x >= 5.47)
        {
            xDirection = -1;
            _comSpriteRenderer.flipX = true;
        }
        if (_comTransform.position.x <= -5.47)
        {
            xDirection = 1;
            _comSpriteRenderer.flipX = false;
        }
        if (_comTransform.position.y >= 4.07)
        {
            yDirection = -1;
            _comSpriteRenderer.flipY = true;
        }
        if (_comTransform.position.y <= -4.07)
        {
            yDirection = 1;
            _comSpriteRenderer.flipY = false;
        }
    }
}
