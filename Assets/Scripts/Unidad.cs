using UnityEngine;

public class Unidad : MonoBehaviour
{
  [SerializeField] private UnidadEnum[] _tipo;
  [SerializeField] private int _vida;
  [SerializeField] private int _fuerza;
  [SerializeField] private string _nombre;
  [SerializeField] private int _movimiento;
  [SerializeField] private (int, int) _posicion;
  [SerializeField] private int _distancia;

  public Unidad(UnidadEnum[] tipo, int vida, int fuerza, string nombre, int movimiento, int distancia, (int, int) posicion)
  {
    _tipo = tipo;
    _vida = vida;
    _fuerza = fuerza;
    _movimiento = movimiento;
    _distancia = distancia;
    _posicion = posicion;
  }

  public UnidadEnum[] Tipo
  { get; set; }

  public int Vida
  { get; set; }

  public string Nombre
  { get; set; }

  public int Movimiento
  { get; set; }

  public int Distancia
  { get; set; }

  public (int, int) Posicion
  { get; set; }
}
