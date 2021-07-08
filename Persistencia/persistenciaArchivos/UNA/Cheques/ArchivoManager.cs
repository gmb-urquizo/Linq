using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.Cheques;

namespace persistenciaArchivos.UNA.Cheques
{
    class ArchivoManager
    {
         
        public List<Cheque> ChequesList { get; set; }
        public ArchivoManager()
        {
            ChequesList = new List<Cheque>();
        }
        public string CrearArchivo(string rutaBase) { 
            string path = $"{DateTime.Now.ToString()}.csv";
            path= path.Replace("/", "_");
            path= path.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Cheque cheque in ChequesList) 
                { 
                    var line =  $"{cheque.Nombre},{cheque.Numero},{cheque.Monto},{cheque.Descripcion}";
                    streamWriter.WriteLine(line);
                }
                    streamWriter.Flush();
                return path;
            }
        }
        public void LeerArchivo() {
        }
    }
}
