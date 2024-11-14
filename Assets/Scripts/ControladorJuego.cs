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
    GameObject MaquinasRecreativas, Personas, MaquinaVendedoras, Muebles, Aleatorio;
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
        MenuObjetos.SetActive(false);
    }

    
    void Update()
    {
        Play();
        Construcion();
        MaquinaRecreativa();
        Persona();
        AccionAleatorio();
        MaquinasVendedoras();
        Mobiliario();
        Movimiento();
        Rotacion();
        borrar();
    }

    private void Play()
    {
        if (BotonInicio.activeSelf)
        {
            EditorEscena.SetActive(true);
            
        }
    }
    public void Construcion()
    {
        if (Contruccion.activeSelf)
        {
            MenuObjetos.SetActive(true);
        }
    }
    private void MaquinaRecreativa()
    {
        if (MaquinasRecreativas.activeSelf)
        {
            MenuMR.SetActive(true);
        }
    }
    private void Persona() 
    {
        if (Personas.activeSelf)
        {
            MenuP.SetActive(true);
        }
    }
    private void AccionAleatorio()
    {
        
    }
    private void MaquinasVendedoras()
    {
        if (MaquinaVendedoras.activeSelf)
        {
            MenuMV.SetActive(true);
        }
    }
    private void Mobiliario()
    {
        if (Muebles.activeSelf)
        {
            MenuM.SetActive(true);
        }
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