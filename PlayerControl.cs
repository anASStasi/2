using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float _jumpforce;
    [SerializeField] private ContactFilter2D _platforms;

    private Rigidbody2D _rigidbody;

    private bool isOnPlatform=>_rigidbody.IsTouching(_platforms);

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if(isOnPlatform == true)
            _rigidbody.AddForce(Vector2.up * _jumpforce, ForceMode2D.Impulse);
    }

    
}

