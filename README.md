# Laboratorio 5: Aplicacion de patrones de diseño de comportamiento
Implementación de Patrón de Dieño de Comportamiento implementado en C# y haciendo uso de repl.it


Este es un problema que plantea el desarrollo de una aplicacion para una universidad en el cual se pueda exportar los datos de los estudiantes en 3 formatos distintos ya sea formato csv, xml o json.

Para resolver este problema se utiliza el patrón Strategy.

El contexto es: ExportarEstudiantes

Las estrategías concretas son:
- CsvExportar (exporta la lista de estudiantes a formato csv)
- XmlExportar (exporta la lista de estudiantes a formato xml)
- JsonExportar (exporta la lista de estudiantes a formato json)