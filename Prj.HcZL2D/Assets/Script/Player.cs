using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)] public float moveSpeed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)] public int jumpHeight = 100;
    [Header("是否著地"), Tooltip("如果在地上為True")] public bool onGround = false;
    int score = 0;
    [Header("子彈預製物"), Tooltip("放入子彈的Prefab")] public GameObject bulletPrefab;
    [Header("子彈生成點"), Tooltip("子彈生成點的空物件")] public Transform bulletSpwanPoint;
    [Range(0, 5000)] public int bulletSpeed = 800;
    [Header("開槍音效"), Tooltip("放入音效檔案")] public AudioClip gunFireSound;
    [Range(0, 10)] public int hp = 3;
    AudioSource audioS;
    Rigidbody2D rig2D;
    Animator ani;
    #endregion

    void Move()
    {

    }

    void Jump()
    {

    }

    void Fire()
    {

    }

    void Dead(string hitObjName)
    {

    }
}
