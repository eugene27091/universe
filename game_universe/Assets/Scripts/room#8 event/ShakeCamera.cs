using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    public float ShakeAmount; // 카메라가 흔들리는 힘
    float ShakeTime; // 카메라가 흔들리는 시간    
    Vector3 initialPosition; // 카메라의 흔들리는 위치
  
    void Start()
    {
        initialPosition = new Vector3(0f, 0f, -10f); // main camera 위치
    }

    void Update()
    {
        if (ShakeTime > 0)
        {
            transform.position = Random.insideUnitSphere * ShakeAmount + initialPosition; // 랜덤으로 카메라의 움직임 총량 만큼 카메라의 위치에서 흔들림
            ShakeTime -= Time.deltaTime;
        }
        else
        {
            ShakeTime = 0.0f;
            transform.position = initialPosition;
        }
    }

    public void VibrateForTime(float time)
    {
        ShakeTime = time; // 카메라 흔드는 시간 결정
    }
}
