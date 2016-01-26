using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc;
            Console.WriteLine("De una orden: ");
            opc = Console.ReadLine();  
            //codigo para leer
            StreamReader objReader,obje,obj,ob,o;

               objReader = new StreamReader("D:\\asistente v.2.0\\3.0\\sustxt\\eje.txt");
            string sLine = "";
            ArrayList arrText = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();
            //dentro es el qe hay que leer
            foreach (string descargas in arrText)
                if (opc == "descargas")
                {

                    System.Diagnostics.Process.Start(@"C:\Users\" + (descargas) + @"\Downloads");
                    Console.WriteLine();

                }

                   obje = new StreamReader("D:\\asistente v.2.0\\3.0\\sustxt\\fotos.txt");
            string sLin = "";
            ArrayList arrTex = new ArrayList();
            while (sLin != null)
            {
                sLin = obje.ReadLine();
                if (sLin != null)
                    arrTex.Add(sLin);
            }
            obje.Close();
          foreach (string foto in arrTex)

              if (opc == "fotos")
              {
                  System.Diagnostics.Process.Start(@"" + foto);
              }

                obj = new StreamReader("D:\\asistente v.2.0\\3.0\\sustxt\\foto2.txt");
            string sLi = "";
            ArrayList arrTe = new ArrayList();
            while (sLi != null)
            {
                sLi = obj.ReadLine();
                if (sLi != null)
                    arrTe.Add(sLi);
            }
            obj.Close();
          
            foreach (string foo in arrTe)
                //condicion

               

            if(opc=="fotos"){
              
                System.Diagnostics.Process.Start(@"" + foo);
                
            }

            o = new StreamReader("D:\\asistente v.2.0\\3.0\\sustxt\\nombrepc.txt");
            string s = "";
            ArrayList arr = new ArrayList();
            while (s != null)
            {
                s = o.ReadLine();
                if (s != null)
                    arr.Add(s);
            }
            o.Close();

            foreach (string mi in arr)
             Console.ReadLine();
        }
    }
}
