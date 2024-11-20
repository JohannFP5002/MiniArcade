using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class ControladorJuego : MonoBehaviour
{
    [Header("Objetos")]
    public GameObject Objeto1;
    public GameObject Objeto2;
    public GameObject Objeto3;
    public GameObject Objeto4;
    public GameObject Objeto5;
    public GameObject Objeto6;
    public GameObject Objeto7;
    public GameObject Objeto8;
    public GameObject Objeto9;
    public GameObject Objeto10;
    public GameObject Objeto11;
    public GameObject Objeto12;
    public GameObject Objeto13;
    [SerializeField]
    float timeanim;
    [SerializeField]
    LeanTweenType animCurve;
    [SerializeField]
    GameObject BotonInicio;
    [SerializeField]
    GameObject EditorEscena;
    [SerializeField]
    GameObject MenuObjetos;
    [SerializeField]
    GameObject MensajeConstruccion, MensajeMover, MensajeRotar, MensajeEliminar;
    [SerializeField]
    GameObject MaquinasRecreativas, Personas, MaquinaVendedoras, Muebles;
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
    bool MaquinaRecreativas = false;
    bool Persona = false;
    bool MaquinaVendedora = false;
    bool Mueble = false;
    bool PopMovimiento = false;
    bool PopRotacion = false;
    bool PopEliminar = false;
    bool BotonesObjetos = false;
    private bool MovimientoObjetos = false;
    private GameObject SelectObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.CompareTag("Select"))
                {
                    // Selecciona el objeto al hacer clic en él
                    SelectObject = hit.transform.gameObject;
                    Debug.Log("Objeto seleccionado: " + SelectObject.name);
                }
            }
        }

        // Movimiento del objeto seleccionado si el modo mover está activo
        if (MovimientoObjetos && SelectObject != null)
        {
            if (Input.GetKey(KeyCode.W))
            {
                SelectObject.transform.position += Vector3.back * Time.deltaTime; // Mover hacia adelante (eje Z)
            }
            if (Input.GetKey(KeyCode.S))
            {
                SelectObject.transform.position += Vector3.forward * Time.deltaTime; // Mover hacia atrás (eje Z)
            }
            if (Input.GetKey(KeyCode.A))
            {
                SelectObject.transform.position += Vector3.right * Time.deltaTime; // Mover hacia la izquierda (eje X)
            }
            if (Input.GetKey(KeyCode.D))
            {
                SelectObject.transform.position += Vector3.left * Time.deltaTime; // Mover hacia la derecha (eje X)
            }
        }
    }
    public void MenuInicio()
    {
        Inicio = !Inicio;
        if (Inicio)
        {
            LeanTween.moveLocalY(EditorEscena, -400f, timeanim).setEase(animCurve);
        }
        
    }

    public void PopupConstruccion() 
    {
        PopConstruccion = !PopConstruccion;
        if (PopConstruccion) 
        {
            LeanTween.moveLocalY(MenuObjetos, 450f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeConstruccion, -400f, timeanim).setEase(animCurve);
                LeanTween.moveLocalY(MensajeMover, -800f, timeanim).setEase(animCurve);
                LeanTween.moveLocalY(MensajeRotar, -800f, timeanim).setEase(animCurve);
                LeanTween.moveLocalY(MensajeEliminar, -800f, timeanim).setEase(animCurve);
        }
    }
    public void PopupMovimiento()
    {
        PopMovimiento = !PopMovimiento;
        if (PopMovimiento)
        {
            LeanTween.moveLocalY(MensajeMover, -400f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeConstruccion, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeRotar, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeEliminar, -800f, timeanim).setEase(animCurve);
        }
    }
    public void PopupRotacion()
    {
        PopRotacion = !PopRotacion;
        if (PopRotacion)
        {
            LeanTween.moveLocalY(MensajeRotar, -400f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeMover, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeConstruccion, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeEliminar, -800f, timeanim).setEase(animCurve);
        }
    }
    public void PopupEliminar()
    {
        PopEliminar = !PopEliminar;
        if (PopEliminar)
        {
            LeanTween.moveLocalY(MensajeEliminar, -400f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeMover, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeRotar, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeConstruccion, -800f, timeanim).setEase(animCurve);
        }
    }
    public void MaquinasR()
    {
        MaquinaRecreativas = !MaquinaRecreativas;
        if (MaquinaRecreativas)
        {
            LeanTween.moveLocalY(MenuMR, 50f, timeanim).setEase(animCurve);
        }
    }
    public void Seres()
    {
        Persona = !Persona;
        if (Persona)
        {
            LeanTween.moveLocalY(MenuP, 50f, timeanim).setEase(animCurve);
        }
    }
    public void MaquinasV()
    {
        MaquinaVendedora = !MaquinaVendedora;
        if (MaquinaVendedora)
        {
            LeanTween.moveLocalY(MenuMV, 50f, timeanim).setEase(animCurve);
        }
    }
    public void Cosos()
    {
        Mueble = !Mueble;
        if (Mueble)
        {
            LeanTween.moveLocalY(MenuM, 50f, timeanim).setEase(animCurve);
        }
    }
    public void CierrePopObjetos()
    {
        BotonesObjetos = !BotonesObjetos;
        if (BotonesObjetos)
        {
            LeanTween.moveLocalY(EditorEscena, -600f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MenuObjetos, 850f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeConstruccion, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeMover, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeRotar, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MensajeEliminar, -800f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MenuMR, 850f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MenuP, 850f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MenuMV, 850f, timeanim).setEase(animCurve);
            LeanTween.moveLocalY(MenuM, 850f, timeanim).setEase(animCurve);
        }
    }
    private void CrearObjeto(GameObject Objetos, int objetoId)
    {
        if (Objetos != null)
        {
            Vector3 posicionInicial = new Vector3(3, 1, 3); // Cambiar si se requiere otra posición
            GameObject nuevoObjeto = Instantiate(Objetos, posicionInicial, Quaternion.identity);
            nuevoObjeto.tag = "Select";
            nuevoObjeto.name = "Objetos" + objetoId;
        }
    }
    public void BorrarObjeto()
    {
        if (SelectObject != null)
        {
            Destroy(SelectObject);
            SelectObject = null;  // Limpiar la referencia
        }
    }
    public void RotacionObjeto()
    {
        if (SelectObject != null)
        {
            SelectObject.transform.Rotate(Vector3.up, 90f);  // Rotar 45 grados en el eje Y
        }
    }
    public void MovimientoObjeto()
    {
        MovimientoObjetos = true;
    }
    public void AirHockey()
    {
        CrearObjeto(Objeto1, 1);
    }
    public void ArcadeMachines()
    {
        CrearObjeto(Objeto2, 2);
    }
    public void BasketBall()
    {
        CrearObjeto(Objeto3, 3);
    }
    public void DanceMachines()
    {
        CrearObjeto(Objeto4, 4);
    }
    public void Chicas()
    {
        CrearObjeto(Objeto5, 5);
    }
    public void Chicos()
    {
        CrearObjeto(Objeto6, 6);
    }
    public void TicketMachines()
    {
        CrearObjeto(Objeto7, 7);
    }
    public void VendingMachines()
    {
        CrearObjeto(Objeto8, 8);
    }
    public void ClawMachines()
    {
        CrearObjeto(Objeto9, 9);
    }
    public void Cashregister()
    {
        CrearObjeto(Objeto10, 10);
    }
    public void Prize()
    {
        CrearObjeto(Objeto11, 11);
    }
    public void PrizeWheels()
    {
        CrearObjeto(Objeto12, 12);
    }
    public void Columns()
    {
        CrearObjeto(Objeto13, 13);
    }
}