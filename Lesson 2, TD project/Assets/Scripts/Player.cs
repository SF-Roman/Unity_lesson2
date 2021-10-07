using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnBulletPoint;
    [SerializeField] private Transform _enemy;
    public float speed = 2;
    public float bulletSpeed = 2;

    [HideInInspector] public float damage;
    private Vector3 _direction;
    private bool _isFire;
    private bool _isSprint;
    void Awake()
    {
        _direction = Vector3.zero;
        damage = 4;

    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            //_isFire;

        _isSprint = Input.GetButton("Sprint");
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Move();

    }
    private void Move()
    {
        Vector3 direction = _direction.normalized * ((_isSprint) ? speed * 2 : speed) * Time.fixedDeltaTime;
        transform.position += direction;
    }
}
