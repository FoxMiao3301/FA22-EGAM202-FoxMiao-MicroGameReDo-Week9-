using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BreakShot : MonoBehaviour
{
    // Start is called before the first frame update

    public bool hurt;
    public bool HitOrNot = false;
    public bool Check;
    public Animator PL;
    public GameObject Camera;
    public GameControl GC;

    private void Start()
    {
        PL = GameObject.Find("HitUi").GetComponent<Animator>();
        Camera = GameObject.Find("Main Camera");
        GC = GameObject.Find("PlayerControll").GetComponent<GameControl>();
        Check = true;
        hurt = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "spider" && other.isTrigger && hurt == true)
        {
            GameObject.Find("MainSystem").GetComponent<MainSystem>().WinPoint += 1;
            PL.SetTrigger("Green");

            Destroy(other.gameObject);
            hurt = false;
            HitOrNot = true;
            GC.CreateBroke();

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Check == true)
        {
            CheckHurt();
            Check = false;
        }
        

    }

    void CheckHurt()
    {
        if (Time.deltaTime > 0.01)
        {
            hurt = false;
            if (HitOrNot == false)
            {
                Debug.Log("You suck bro");
                PL.SetTrigger("Red");
                Camera.GetComponent<Animator>().SetTrigger("Shake");
                //var newRotation = Quaternion.LookRotation(transform.position);
                //newRotation.x = 0.0f;
                //newRotation.y = 0.0f;
                //newRotation.z += 0.0001f;
                //Camera.transform.rotation = newRotation;
            }
        }

    }
}
