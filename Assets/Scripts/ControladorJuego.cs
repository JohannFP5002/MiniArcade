using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ControladorJuego : MonoBehaviour
{
    
    [SerializeField]
    float timeanim;
    [SerializeField]
    LeanTweenType animCurve;
    [SerializeField]
    GameObject BotonInicio;
    [SerializeField]
    float PosicionFinal = 50f;
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
    GameObject AirHock, ArcadeMachine, Basketball, DanceMachine;
    [SerializeField]
    GameObject Chica, Chico;
    [SerializeField]
    GameObject TicketMachine, VendingMachine, ClawMachine;
    [SerializeField]
    GameObject CashRegister, Prizes, PrizeWheel, Column;
    bool Inicio = false;
    bool PopConstruccion = false;
    bool PopMovimiento = false;
    bool PopRotacion = false;
    bool PopEliminar = false;


    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void MenuInicio()
    {
        Inicio = !Inicio;
        if (Inicio)
        {
            LeanTween.moveLocalY(EditorEscena, PosicionFinal, timeanim).setEase(animCurve);
        }
        
    }

    private void PopupConstruccion() 
    {
        PopConstruccion = !PopConstruccion;
       
    }
    private void PopupMovimiento()
    {
        
    }
    private void PopupRotacion()
    {
        
    }
    private void PopupEliminar()
    {

    }
   
}