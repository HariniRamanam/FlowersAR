using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMang : MonoBehaviour
{
    public GameObject f1, f2, f3;

    // Start is called before the first frame update
    public void F1()
    {
        f1.SetActive(true);
        f2.SetActive(false);
        f3.SetActive(false);
    }
    public void F2()
    {
        f1.SetActive(false);
        f2.SetActive(true);
        f3.SetActive(false);
    }
    public void F3()
    {
        f1.SetActive(false);
        f2.SetActive(false);
        f3.SetActive(true);
    }
}
