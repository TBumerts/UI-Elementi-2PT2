using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai lietotu pointer darbību interfeisu
using UnityEngine.EventSystems;
// piesaista interface

public class ObjektuParvietosana : MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform transformKomponente;
    public Canvas kanva;
    void start() {
        //Startējot automātiski piekļūst attēla transform komponentei un piefiksē kādās koordinātās attēls atrodas
        transformKomponente = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData notikums) {
        Debug.Log("Izdarīts peles klikškis uz objekta!");

    }
    public void OnBeginDrag(PointerEventData notikums) 
    {
        Debug.Log("Uzsākta objekta vilkšana!");
    }
    public void OnDrag(PointerEventData notikums) 
    {
        Debug.Log("Notiek objekta pārvietošana!");
        transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor  ;
    }
    public void OnEndDrag(PointerEventData notikums) 
    {
        Debug.Log("Objekta pārvietošana beigta!");
    }
}
