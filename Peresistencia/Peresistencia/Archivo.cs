using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Peresistencia
{
    class Archivo
    {
        private FileStream mArchivo;
        private BinaryFormatter Convertidor;

        public bool GuardarPersona(Persona mPersona)
        {
            try{
                mArchivo = new FileStream("archivo.dat", FileMode.Open, FileAccess.Write);
                Convertidor = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                Convertidor.Serialize(mArchivo, mPersona);
                mArchivo.Close();
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                return true;
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Persona LeerPersona()
        {
            Persona mPersona = null;
            try
            {
                mArchivo = new FileStream("archivo.dat", FileMode.Open, FileAccess.Write);
                Convertidor = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                mPersona = (Persona) Convertidor.Deserialize(mArchivo);
                mArchivo.Close();
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                return mPersona;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
