using UnityEngine;

public class Edificio : MonoBehaviour
{
  [SerializeField] private EdificioEnum[] _tipo;
  [SerializeField] private int _vida;
  [SerializeField] private int _fuerza;
  [SerializeField] private string _nombre;
  [SerializeField] private (int, int) _posicion;
  [SerializeField] private int _distancia;

  public Edificio(EdificioEnum[] tipo, int vida, int fuerza, string nombre, (int, int) posicion, int distancia)
  {
    _tipo = tipo;
    _vida = vida;
    _fuerza = fuerza;
    _nombre = nombre;
    _posicion = posicion;
    _distancia = distancia;
  }

  public EdificioEnum[] Tipo
  { get; set; }

  public int Vida
  { get; set; }

  public int Fuerza
  { get; set; }

  public string Nombre
  { get; set; }

  public int Distancia
  { get; set; }

  public (int, int) Posicion
  { get; set; }
}
