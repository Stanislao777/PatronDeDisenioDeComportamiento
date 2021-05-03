using System;
using System.Collections.Generic;

class ExportarEstudiantes
{
	private Universidad universidad;
	private IStrategyExportar strategyExportar;

	public ExportarEstudiantes(Universidad universidad)
	{
		this.universidad = universidad;
	}

	public void setStrategy(IStrategyExportar strategyExportar)
	{
		this.strategyExportar = strategyExportar;
	}

	public void exportar()
	{
		List<Estudiante> estudiantes = universidad.getEstudiantes();
		string texto = strategyExportar.exportar(estudiantes);
		Console.WriteLine("{0}", texto);
	}
}
