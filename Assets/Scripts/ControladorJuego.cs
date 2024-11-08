using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour
{
    [SerializeField]
    GameObject BotonInicio;
    [SerializeField]
    GameObject EditorEscena;
    [SerializeField]
    GameObject MenuObjetos;
    [SerializeField]
    GameObject MenuMR, MenuP, MenuMV, MenuM;
    [SerializeField]
    GameObject Contruccion, Mover, Rotar, Eliminar;
    [SerializeField]
    GameObject AirHock, ArcadeMachine, Basketball, DanceMachine, Gambling, Pintaball;
    [SerializeField]
    GameObject Chica, Chico;
    [SerializeField]
    GameObject TicketMachine, VendingMachine, ClawMachine;
    [SerializeField]
    GameObject CashRegister, Prizes, PrizeWheel, Column;
    

    void Start()
    {
        BotonInicio.SetActive(true);
        EditorEscena.SetActive(false);
    }

    
    void Update()
    {
        Play();
    }

    private void Play()
    {
        if (BotonInicio == false)
        {
            EditorEscena.SetActive(true);
            
        }
    }
    private void Construcion()
    {
        if(Contruccion == false)
        {
            MenuObjetos.SetActive(true);
        }
    }
    private void MaquinaRecreativa()
    {

    }
    private void Persona() 
    {

    }
    private void Aleatorio()
    {

    }
    private void MaquinasVendedoras()
    {

    }
    private void Muebles()
    {

    }
    private void Movimiento()
    {

    }
    private void Rotacion()
    {

    }
    private void borrar()
    {

    }
}
