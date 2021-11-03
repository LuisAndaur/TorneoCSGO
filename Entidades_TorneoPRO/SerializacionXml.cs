using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades_TorneoPRO
{
    public class SerializacionXml<T>
    {
        static string path;

        static SerializacionXml()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }

        public static void Escribir(T datos)
        {
            string nombreArchivo = path + "SerializacionXml_01_" + DateTime.Now.ToString("HH_mm_ss") + ".xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }


        public static T Leer()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datos = default;
            try
            {

                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("SerializacionXml_01_"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

    }
}
