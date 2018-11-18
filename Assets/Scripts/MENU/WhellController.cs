using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhellController : MonoBehaviour {

    public void startWheel()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Rotation");
    }
}
