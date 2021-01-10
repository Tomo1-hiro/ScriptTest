using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    public class Boss
    {

        int mp = 53;
        public void Magic()
        {
            if (mp >= 5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);

            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }

        }          
                   
            

        }
    
    void Start()
    {
        Boss lastboss = new Boss();
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }


    }

   
    