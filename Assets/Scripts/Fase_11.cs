using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fase_11 : MonoBehaviour
{
    public int placar = 0;

    public Text placar_text;

    // Start is called before the first frame update
    void Start()
    {
        placar = PlayerPrefs.GetInt("placar");
        placar_text.text = "Pontos: " + placar.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
