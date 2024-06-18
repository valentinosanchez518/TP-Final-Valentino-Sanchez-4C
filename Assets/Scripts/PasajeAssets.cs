using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasajeAssets : MonoBehaviour
{
    public GameObject[] Assets;
    public int CurrentIndex = -1;
    public int CurrentIndexmas = 0;
    public int CurrentIndexmenos = -2;

    // Start is called before the first frame update
    void Start()
    {
        DesactivarTodo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PasarObjeto();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ObjetoAnterior();
        }

    }

    public void PasarObjeto()
    {
        CurrentIndex++;
        CurrentIndexmas++;
        CurrentIndexmenos++;
        if (CurrentIndex >= Assets.Length)
        {
            CurrentIndex = 0;
        }
        Assets[CurrentIndex].SetActive(true);
        Assets[CurrentIndexmenos].SetActive(false);
    }

    public void ObjetoAnterior()
    {
        CurrentIndex--;
        CurrentIndexmas--;
        CurrentIndexmenos--;
        if (CurrentIndex < 0)
        {
            CurrentIndex = Assets.Length -1;
        }
        Assets[CurrentIndex].SetActive(true);
        Assets[CurrentIndexmas].SetActive(false);
    }

    public void DesactivarTodo()
    {
        for (int i = 0; i < Assets.Length; i++)
        {
            Assets[i].SetActive(false);
        }
    }
}
