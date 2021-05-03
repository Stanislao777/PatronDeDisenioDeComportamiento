using System.Collections.Generic;

class XmlExportar : IStrategyExportar
{
	public string exportar(List<Estudiante> estudiantes)
	{
		string respuesta = "";
		respuesta += "<Estudiantes>";
		foreach(Estudiante estudiante in estudiantes)
		{
			respuesta += "\n";
			respuesta += "  <Estudiante>\n";
			respuesta += "    <Ci>" + estudiante.getCi() + "</Ci>\n";
			respuesta += "    <Nombre>" + estudiante.getNombre() + "</Nombre>\n";
			respuesta += "    <Apellido>" + estudiante.getApellido() + "</Apellido>\n";
			respuesta += "    <Carrera>" + estudiante.getCarrera() + "</Carrera>\n";
			
			respuesta += "  </Estudiante>";
		}
		respuesta += "\n</Estudiantes>";
		return respuesta;
	}
}