using System.Collections.Generic;

class CsvExportar : IStrategyExportar
{
	public string exportar(List<Estudiante> estudiantes)
	{
		string respuesta = "";
		respuesta += "Ci,Nombre,Apellido,Carrera";
		foreach(Estudiante estudiante in estudiantes)
		{
			respuesta += "\n";
			respuesta += estudiante.getCi() + ",";
			respuesta += estudiante.getNombre() + ",";
			respuesta += estudiante.getApellido() + ",";
			respuesta += estudiante.getCarrera();
		}
		return respuesta;
	}
}