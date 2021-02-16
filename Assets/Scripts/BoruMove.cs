using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//BURASI DEĞİŞTİRİLDİ
public class BoruMove : MonoBehaviour
{
    public float speed;
    private float time= 6f;
//BURASI DEĞİŞTİRİLDİ
    private void Start()
    {
        Destroy(gameObject, time);
    }
    //BURASI DEĞİŞTİRİLDİ
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
