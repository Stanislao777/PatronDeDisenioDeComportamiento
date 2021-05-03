using System.Collections.Generic;

class Universidad
{
	private List<Estudiante> estudiantes;

	public Universidad()
	{
		estudiantes = new List<Estudiante>();
	}

	public void agregarEstudiante(Estudiante estudiante)
	{
		estudiantes.Add(estudiante);
	}

	public List<Estudiante> getEstudiantes()
	{
		return estudiantes;
	}
}