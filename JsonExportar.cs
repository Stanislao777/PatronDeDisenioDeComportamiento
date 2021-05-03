using System.Collections.Generic;

class JsonExportar : IStrategyExportar
{
	public string exportar(List<Estudiante> estudiantes)
	{
		string respuesta = "";
		respuesta += "[";
		for(int index = 0; index < estudiantes.Count; index++)
		{
			Estudiante estudiante = estudiantes[index];
			respuesta += "\n";
			respuesta += "  {\n";
			respuesta += "    ci: " + estudiante.getCi() + ",\n";
			respuesta += "    nombre: \"" + estudiante.getNombre() + "\",\n";
			respuesta += "    apellido: \"" + estudiante.getApellido() + "\",\n";
			respuesta += "    carrera: \"" + estudiante.getCarrera() + "\"\n";
			respuesta += "  }";
			if(index < estudiantes.Count - 1)
			{
				respuesta += ",";
			}
			else
			{
				respuesta += "\n";
			}		
		}
		respuesta += "]";
		return respuesta;
	}
}