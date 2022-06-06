using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) {
            texto.text = "Pika,Pika";
        }
        if(Input.GetKeyDown(KeyCode.B)) {
            texto.text = "si apagas mi llamita me muero T.T";
        }
        if(Input.GetKeyDown(KeyCode.C)) {
            texto.text = "si te duermes mientras canto, te rallare la cara >).(<";
        }
        if(Input.GetKeyDown(KeyCode.D)) {
            texto.text = "vamo a calmarnos";
        }
    }
}
