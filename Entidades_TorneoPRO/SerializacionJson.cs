using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public static class SerializacionJson<T>
    {

        static string path;

        static SerializacionJson()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }

        public static void Escribir(T datos, string nombre)
        {
            string nombreArchivo = path + "SerializandoJson_" + nombre + ".json";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos));

            }
            catch (Exception e)
            {
                throw new Exception_SerializacionJson($"Error en el archivo ubicado en {path}", e);
            }
        }


        public static T Leer(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;
            try
            {

                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }
                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception_SerializacionJson($"Error en el archivo ubicado en {path}", e);
            }
        }

        public static T LeerInicial(string nombre)
        {
            path = $"{Environment.CurrentDirectory}\\{nombre}";
            string info = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;
            try
            {
                info = File.ReadAllText(path);
                datosRecuperados = JsonSerializer.Deserialize<T>(info);
                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception_SerializacionJson($"Error en el archivo ubicado en {path}", e);
            }

        }
    }
}
