using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("車子數值")]
    [Tooltip("CC數"),Range(500,5000)] public int cc           = 1000;
    [Tooltip("重量")]                 public float weight     = 1000.5f;
    [Tooltip("品牌")]                 public string brand     = "BMW";
    [Tooltip("有沒有天窗")]           public bool haveWindow  = true;

    [Header("顏色")]
    public Color red         = Color.red;
    public Color yellow      = Color.yellow;
    public Color customColor = new Color(1, 1, 1);

    [Header("座標數據")]
    [Tooltip("二維原點")] public Vector2 pos2Zero = Vector2.zero;
    [Tooltip("二維壹壹")] public Vector2 pos2One  = Vector2.one;
    [Tooltip("二維座標")] public Vector2 pos2     = new Vector2(5, 6);
    [Tooltip("三維座標")] public Vector3 pos3     = new Vector3(5, 6, 7);
    [Tooltip("四維座標")] public Vector4 pos4     = new Vector4(1, 2, 3, 4);

    [Header("元件引用")]
    [Tooltip("物件")] public GameObject obj;
    [Tooltip("變形")] public Transform tf;
    [Tooltip("渲染")] public SpriteRenderer sr;

    private void Start()
    {
        print("A");
        Fire();
        Fire(5, 200);
        Fire(8, 50);
    }

    private void Update()
    {
        print("B");

        Drive(.1f);
    }

    void Drive(float speed)
    {
        print("開車中......");
        transform.Translate(speed, 0, 0);
    }

    /// <summary>
    /// 發射功能
    /// </summary>
    /// <param name="time">發射的數量(倍數),預設3</param>
    /// <param name="speed">發射子彈的速度,預設100</param>
    void Fire(int time = 3, float speed = 100)
    {
        print("That car shoot " + time + " bullet and the bullet speed is " + speed);
    }
}
