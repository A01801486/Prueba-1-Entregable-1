using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Anim01Events : MonoBehaviour
{

    public GameObject fadeScreenIn;
    public GameObject charCryptoChick;
    public GameObject charWeb;
    public GameObject textBox;
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds (2);
        charCryptoChick.SetActive(true);
        yield return new WaitForSeconds (2);
        //text
        textBox.SetActive(true);
        yield return new WaitForSeconds (2);
        charWeb.SetActive(true);
    }

}
