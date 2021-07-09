using System;

namespace Peresistencia
{
    class Program
    {
        private Persona mPersona;
        private Archivo mArchivo;

        public Program()
        {
            mArchivo = new Archivo();
        }

        public void Correr()
        {
            mPersona = new Persona();
            mPersona.SetNombre("Wiliam");
            mPersona.SetEdad(45);
            mArchivo.GuardarPersona(mPersona);

            mPersona = mArchivo.LeerPersona();
            if (mPersona != null)
            {
                Console.WriteLine(mPersona.GetNombre() + "-" + mPersona.GetEdad());
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();

        }
    }
}
