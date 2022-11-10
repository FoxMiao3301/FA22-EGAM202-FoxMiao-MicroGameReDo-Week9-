using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public MainSystem MS;
    public GameObject Break;
    public GameObject DeadS;
    public GameObject[] BreakEffect;
    // Update is called once per frame
    void Update()
    {
        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        gameObject.transform.position = pz;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            MS.BreakPoint -= 1;
            Debug.Log("Mouse 0 ");
            GameObject BreakPic = (GameObject)Instantiate(Break,pz, transform.rotation);
        }

        if (MS.BreakPoint <= 0)
        {
            CleanAll();
            MS.Lose = true;
        }
    }


    public void CreateBroke()
    {
        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        GameObject DeadPic = (GameObject)Instantiate(DeadS,pz, transform.rotation);
    }


    void CleanAll()
    {
        BreakEffect = GameObject.FindGameObjectsWithTag("Break");
        foreach (GameObject CleanBreak in BreakEffect)
        {
            Destroy(CleanBreak);
        }
    }


}
