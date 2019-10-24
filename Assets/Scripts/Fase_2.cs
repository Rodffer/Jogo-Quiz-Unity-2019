using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fase_2 : MonoBehaviour
{

	public int placar = 0;
    public Text placar_text;

    void Start()
    {
        placar = PlayerPrefs.GetInt("placar");
        placar_text.text = "Pontos: " + placar.ToString();
    }

    void Update()
    {
        
    }
}
