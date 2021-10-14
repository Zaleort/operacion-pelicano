using UnityEngine;

public class Casilla : MonoBehaviour
{
  [SerializeField] private TerrenoEnum _terreno;
  [SerializeField] private Edificio _edificio;
  [SerializeField] private Unidad _unidad;
  [SerializeField] private RecursoEnum _recurso;
  [SerializeField] private (int, int) _posicion;

  public Casilla(TerrenoEnum terreno, Unidad unidad, Edificio edificio, RecursoEnum recurso, (int, int) posicion)
  {
    _terreno = terreno;
    _unidad = unidad;
    _edificio = edificio;
    _recurso = recurso;
    _posicion = posicion;
  }

  public TerrenoEnum Terreno
  { get; set; }

  public Unidad Unidad
  {
    get { return _unidad; }
    set
    {
      _unidad = value;
      _unidad.Posicion = _posicion;
    }
  }

  public RecursoEnum Recurso
  { get; set; }

  public Edificio Edificio
  {
    get { return _edificio; }
    set
    {
      _edificio = value;
      _edificio.Posicion = _posicion;
    }
  }

  public (int, int) Posicion
  { get; set; }
}
