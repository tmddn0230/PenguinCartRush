using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitItems : MonoBehaviour
{
    public GameObject lPos;
    public GameObject rPos;

    public Score scoreScripts;

    public SoundManager soundScripts;

 


    RaycastHit hit;
    Ray lray;
    Ray rray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            LeftRay();
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            RightRay();
            
        }
    }
    void LeftRay()
    {

        lray = new Ray(lPos.transform.position, lPos.transform.right);



        if (Physics.Raycast(lray, out hit, 15.0f))
        {
                Debug.DrawRay(lPos.transform.position, lPos.transform.right * 15.0f, Color.blue, 0.3f);
                Destroy(hit.transform.gameObject);             
            // 6(-),7(5),8(3) 레이어별 스코어 작용 
            if(hit.transform.gameObject.layer == 6)
            {
                scoreScripts.RemoveLife();
                soundScripts.PlaySoundMinus();
            }
            else if(hit.transform.gameObject.layer == 7)
            {
                scoreScripts.AddScoreFive();
                soundScripts.PlaySound5p();
            }
            else
            {
                scoreScripts.AddScoreThree();
                soundScripts.PlaySound3p();
            }



        }

    }
    void RightRay()
    {
        rray = new Ray(rPos.transform.position, rPos.transform.right * -1);



        if (Physics.Raycast(rray, out hit, 15.0f))
        {
            Debug.DrawRay(rPos.transform.position, rPos.transform.right * -15.0f, Color.blue, 0.3f);
            Destroy(hit.transform.gameObject);

            if (hit.transform.gameObject.layer == 6)
            {
                scoreScripts.RemoveLife();
                soundScripts.PlaySoundMinus();
            }
            else if (hit.transform.gameObject.layer == 7)
            {
                scoreScripts.AddScoreFive();
                soundScripts.PlaySound5p();
            }
            else
            {
                scoreScripts.AddScoreThree();
                soundScripts.PlaySound3p();
            }

        }

    }




}
