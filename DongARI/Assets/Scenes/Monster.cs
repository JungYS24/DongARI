using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] private short hp;
    public Vector3 monsterRespawnposition;
    public Slider HPBar;

    public short HP
    {
        get { return hp; }
        set
        {
            hp = value;
            HPBar.value = hp;
            Debug.Log(hp);
            if (hp < 0)
            {
                gameObject.SetActive(false);
            }
        }



    }

    private void ResetHPBar()
    {
        HPBar.maxValue = hp;
        HPBar.value = hp;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        ResetHPBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
