using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform Tr; // 플레이어의 Tr
    float turnSpeed = 100; // 기울이는 속도 
    float rotX; // 누적되는 각도값

    private Animator anim;



    Obstacle obstacleScript;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        Tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotate(); // 함수 실행 
    }

    void PlayerRotate()
    {
        float r = Input.GetAxis("Horizontal"); // -1 ~ 1 , A D 키로 조작
        rotX += Time.deltaTime * turnSpeed * -r; // 각도 누적 
        rotX = Mathf.Clamp(rotX, -60.0f, 60.0f); // 각도 최대, 최소값 설정 


        if (r < 0)
        {
            Tr.localEulerAngles = new Vector3(0.0f, rotX, 0.0f); // 기울이기
            anim.SetBool("IsAttack", true);


        }
        else if (r > 0)
        {
            Tr.localEulerAngles = new Vector3(0.0f, rotX, 0.0f); // 기울이기
            anim.SetBool("IsAttack", true);

        }
        else
        {
            Tr.localEulerAngles = Vector3.zero; // 키를 떼면 제자리로 돌아오게 하기
            rotX = 0; // 누적된 각도값도 초기화
            anim.SetBool("IsAttack", false);
        }

    }






}
