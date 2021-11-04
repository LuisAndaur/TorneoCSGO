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

        /// <summary>
        /// Serializa en un lugar ya definido
        /// </summary>
        /// <param name="datos">datos a serializar</param>
        /// <param name="nombre">nombre del archivo</param>
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

        /// <summary>
        /// Serializa a json con el nombre y en el directorio elegido por el usuario
        /// </summary>
        /// <param name="datos">datos a serializar</param>
        /// <param name="path">ruta de serializacion</param>
        public static void Escribir2(T datos, string path)
        {
            try
            {                
                File.WriteAllText(path, JsonSerializer.Serialize(datos));
            }
            catch (Exception e)
            {
                throw new Exception_SerializacionJson($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Deserializa a json 
        /// </summary>
        /// <param name="nombre">nombre del archivo a deserializar</param>
        /// <returns>retorna los datos deserializados</returns>
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

        /// <summary>
        /// Deserializa desde un archivo predeterminado
        /// </summary>
        /// <param name="nombre">nombre del archivo</param>
        /// <returns>los datos deserializados</returns>
        public static T LeerInicial(string nombre)
        {
            string path2 = $"{Environment.CurrentDirectory}\\{nombre}";
            string info = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;
            try
            {
                info = File.ReadAllText(path2);
                datosRecuperados = JsonSerializer.Deserialize<T>(info);
                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception_SerializacionJson($"Error en el archivo ubicado en {path2}", e);
            }

        }
    }
}
