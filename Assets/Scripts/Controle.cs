using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controle : MonoBehaviour
{
    public int placar = 0;

    public Text placar_text;
    public Text Perdeu;
    public Text Ganhou;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Carrega_Fase_1(){
        SceneManager.LoadScene("Fase_1");
    }

    public void Carrega_Fase_2()
    {
        SceneManager.LoadScene("Fase_2");
    }

    public void Carrega_Fase_3()
    {
        SceneManager.LoadScene("Fase_3");
    }

    public void Carrega_Fase_5()
    {
        SceneManager.LoadScene("Fase_5");
    }

    public void Carrega_Fase_6()
    {
        SceneManager.LoadScene("Fase_6");
    }

    public void Carrega_Fase_7()
    {
        SceneManager.LoadScene("Fase_7");
    }

    public void Carrega_Fase_8()
    {
        SceneManager.LoadScene("Fase_8");
    }

    public void Carrega_Fase_9()
    {
        SceneManager.LoadScene("Fase_9");
    }

    public void Carrega_Fase_10()
    {
        SceneManager.LoadScene("Fase_10");
    }

    public void Carrega_Fase_11()
    {
        SceneManager.LoadScene("Fase_11");
    }

    public void Carrega_Fase_12()
    {
        SceneManager.LoadScene("Fase_12");
    }

    public void Close_Scene()
    {
        Application.Quit();
    }

    public void Resposta_Errada_1()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_2", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_1()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_2", 3);
        PlayerPrefs.SetInt("placar", placar);
    }  

    public void Resposta_Errada_2()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_3", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_2()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_3", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Errada_3()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_5", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_3()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_5", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Errada_5()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_6", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_5()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_6", 3);
        PlayerPrefs.SetInt("placar", placar);
    }
    
    public void Resposta_Errada_6()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_7", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_6()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_7", 3);
        PlayerPrefs.SetInt("placar", placar);
    }
  
    public void Resposta_Errada_7()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_8", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_7()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_8", 3);
        PlayerPrefs.SetInt("placar", placar);
    }
 
    public void Resposta_Errada_8()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_9", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_8()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_9", 3);
        PlayerPrefs.SetInt("placar", placar);
    }
 
    public void Resposta_Errada_9()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_10", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_9()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_10", 3);
        PlayerPrefs.SetInt("placar", placar);
    }
  
    public void Resposta_Errada_10()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_11", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_10()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_11", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Errada_11()
    {
        Perdeu.gameObject.SetActive(true);
        placar = placar - 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_12", 3);
        PlayerPrefs.SetInt("placar", placar);
    }

    public void Resposta_Certa_11()
    {
        Ganhou.gameObject.SetActive(true);
        placar = placar + 1;
        placar_text.text = "Pontos: " + placar.ToString();
        Invoke("Carrega_Fase_12", 3);
        PlayerPrefs.SetInt("placar", placar);
    }
}
