
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

using System.Threading.Tasks;
    using System.Diagnostics;
using System.IO;
using System.Collections;

namespace System.Diagnostics
{
    namespace ConsoleApplication1
    {
        class Program
        {
            static void Main(string[] args)
            {
                string value;
                string Fecha = "", hora = "";
                string opc, opc2, text = " ";
                string rpt;
                int convers = 2;
                SoundPlayer player = new SoundPlayer();


                player.SoundLocation = @"D:\asistente v.2.0\salludo.wav"; player.Play();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hola, ¿Hay algo en lo que pueda ayudarte?");
                Console.WriteLine(); 
               
                
               

                do
                {
                    //Console.WriteLine("");
                    //opc = Console.ReadLine();
                    value = Console.ReadLine();

                    if (value.IndexOf("edad") != -1)
                    {
                        Console.WriteLine(); 
                        rpt = "No tengo edad ,soy una macquina :v";
                        
                        Console.WriteLine(rpt);
                        Console.WriteLine();
                    }
                    if (value.IndexOf("buscar") != -1 && value.IndexOf("google") != -1)
                    {
                        
                        string ee;
                        player.SoundLocation = @"D:\asistente v.2.0\g.wav"; player.Play();
                        Console.WriteLine("Escriba lo que desee buscar en google: ");
                        Console.WriteLine();  
                        ee = Console.ReadLine();

                        System.Diagnostics.Process.Start("https://www.google.com.pe/search?q=" + ee);
                        Console.WriteLine();  
                        player.SoundLocation = @"D:\asistente v.2.0\b.wav"; player.Play();


                    }
                   

                    if (value.IndexOf("buscar") != -1 && value.IndexOf("youtu") != -1)
                    {
                        string yu;
                        player.SoundLocation = @"D:\asistente v.2.0\y.wav"; player.Play();
                        Console.WriteLine("Escriba lo que desee buscar en youtube: ");
                        Console.WriteLine();  
                        yu = Console.ReadLine();
                        System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + yu);
                        Console.WriteLine();  
                        player.SoundLocation = @"D:\asistente v.2.0\b.wav"; player.Play();


                    }
                    

                    if (value.IndexOf("ricardo es pisado?") != -1)
                    {
                        player.SoundLocation = @"D:\asistente v.2.0\pisado.wav"; player.Play();
                        rpt = "Por su puesto xd";
                         
                        Console.WriteLine(rpt);
                        Console.WriteLine(); 


                    }

                    if (value.IndexOf("dime") != -1 && value.IndexOf("fecha") != -1)
                    {
                        Console.Write("La fecha es: ");
                        Fecha = DateTime.Now.ToString("dd/MM/yyyy");
                        Console.WriteLine(Fecha);
                        Console.WriteLine();  
                    }

                    if (value.IndexOf("tiempo") != -1)
                    {
                        player.SoundLocation = @"D:\asistente v.2.0\bus.wav"; player.Play();
                        Console.WriteLine("Buscando en google");
                        System.Diagnostics.Process.Start("https://www.google.com.pe/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=la%20temperatura%20en%20lima%20es");
                        player.SoundLocation = @"D:\asistente v.2.0\listo.wav"; player.Play();
                        Console.WriteLine("Listo");
                        Console.WriteLine();  
                    }


                    if (value.IndexOf("san google") != -1)
                    {
                        System.Diagnostics.Process.Start("https://www.google.com.pe/");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\google.wav"; player.Play();
                       
                    }

                    if (value.IndexOf("face") != -1 || value.IndexOf("facebook") != -1)
                    {
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\face.wav"; player.Play();
                    }

                    if (value.IndexOf("abre youtu") != -1 || value.IndexOf("youtube") != -1)
                    {
                        System.Diagnostics.Process.Start("https://www.youtube.com.pe/");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\youtu.wav"; player.Play();
                    }

                    if (value.IndexOf("wpp") != -1)
                    {
                        System.Diagnostics.Process.Start("https://web.whatsapp.com/");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\wpp.wav"; player.Play();
                    }

                    StreamReader objReader,obje,obj,ob,o;
                    objReader = new StreamReader("D:\\asistente v.2.0\\3.0\\sustxt\\nombrepc.txt");
                    string sLine = "";
                    ArrayList arrText = new ArrayList();
                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();
                        if (sLine != null)
                            arrText.Add(sLine);
                    }
                    objReader.Close();
                    
                    foreach (string descargas in arrText)


                    if (value.IndexOf("descargas") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\"+(descargas)+@"\Downloads");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\des.wav"; player.Play();
                    }

                    if (value.IndexOf("dime") != -1 && value.IndexOf("hora") != -1)
                    {

                        String.Format("{0:HH:mm:ss}");
                        Console.Write("La hora es: ");
                        hora = DateTime.Now.ToString("HH:mm:ss");
                        Console.WriteLine(hora);
                        Console.WriteLine(); 
                    }


                    if (value.IndexOf("disco d") != -1)
                    {
                        System.Diagnostics.Process.Start(@"D:\");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\D.wav"; player.Play();
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

                    if (value.IndexOf("fotos") != -1)
                    {
                        System.Diagnostics.Process.Start(@""+(foto));
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\fotos.wav"; player.Play();
                        Console.WriteLine();
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

                    if (value.IndexOf("fotos") != -1)
                    {
                        
                        System.Diagnostics.Process.Start(@""+(foo));
                    
                   
                    }
                    if (value.IndexOf("sao") != -1 || value.IndexOf("sword art online") != -1)
                    {
                        System.Diagnostics.Process.Start("http://animeflv.net/anime/sword-art-online-2.html");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\sao.wav"; player.Play();
                    }
                    ob = new StreamReader("D:\\asistente v.2.0\\3.0\\sustxt\\nombrepc.txt");
                    string sL = "";
                    ArrayList arrT = new ArrayList();
                    while (sL != null)
                    {
                        sL = ob.ReadLine();
                        if (sL != null)
                            arrT.Add(sL);
                    }
                    ob.Close();

                    foreach (string mu in arrT)


                    if (value.IndexOf("musica") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\"+(mu)+@"\AppData\Roaming\Spotify\spotify.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\musica.wav"; player.Play();
                    }

                    if (value.IndexOf("cerrar musica") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "Spotify")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\m.wav"; player.Play();
                     
                        Console.WriteLine("musica Cerrada");
                        Console.WriteLine(); 
                    }
                    if (value.IndexOf("sony") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Sony\Vegas Pro 11.0\vegas110.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\sony.wav"; player.Play();
                    }

                    if (value.IndexOf("cerrar sony") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "vegas110")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\s.wav"; player.Play();
                        Console.WriteLine("sony Cerrado");
                        Console.WriteLine(); 
                    }
                    if (value.IndexOf("word") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office14\WINWORD.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\word.wav"; player.Play();
                    }

                    if (value.IndexOf("cerrar word") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "WINWORD")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\w.wav"; player.Play();
                        Console.WriteLine("word Cerrado");
                        Console.WriteLine(); 
                    }
                    if (value.IndexOf("exel") != -1 || value.IndexOf("ecxel") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office14\EXCEL.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\exel.wav"; player.Play();
                    }

                    if (value.IndexOf("cerrar exel") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "EXCEL")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\e.wav"; player.Play();
                        Console.WriteLine("exel Cerrado");
                        Console.WriteLine(); 
                    }
                    if (value.IndexOf("ppt") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office14\POWERPNT.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\ppt.wav"; player.Play();
                    }
                    if (value.IndexOf("cerrar ppt") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "POWERPNT")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\p.wav"; player.Play();
                        Console.WriteLine("PPT Cerrado");
                        Console.WriteLine(); 
                    }

                    if (value.IndexOf("cc") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Visual Studio 10.0\Common7\IDE\vcsexpress.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\visual.wav"; player.Play();
                    }
                    if (value.IndexOf("cerrar cc") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "VCSExpress")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\cc.wav"; player.Play();
                       
                        Console.WriteLine("cc Cerrado");
                        Console.WriteLine(); 
                    }

                    if (value.IndexOf("counter") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Counter-Strike 1.6\hl.exe");
                        Console.WriteLine(); 
                    }
                    if (value.IndexOf("notas") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\notas.wav"; player.Play();
                    }
                    if (value.IndexOf("cerrar notas") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "notepad")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\notas.wav"; player.Play();
                        Console.WriteLine("notas Cerrado");
                        Console.WriteLine(); 
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

                    if (value.IndexOf("abre craft") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\"+(mi)+@"\AppData\Roaming\.minecraft\minecraft launcher\Minecraft Launcher.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\m.wav"; player.Play();
                    }

                    if (value.IndexOf("cerrar minecraft") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "javaw")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\mi.wav"; player.Play();
                        Console.WriteLine("minecraft Cerrado");
                        Console.WriteLine(); 
                    }

                    if (value.IndexOf("opera") != -1)
                    {
                    
                        System.Diagnostics.Process.Start(@"C:\Program Files\Opera\launcher.exe");
                        Console.WriteLine(); 
                    }
                    if (value.IndexOf("cerrar opera") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "opera")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\oo.wav"; player.Play();
                        Console.WriteLine("opera Cerrado");
                        Console.WriteLine(); 
                    }

                    if (value.IndexOf("calc") != -1 || value.IndexOf("calculadora") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\calc.wav"; player.Play();
                    }
                    if (value.IndexOf("cerrar calc") != -1 || value.IndexOf("cerrar calculadora") != -1)
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "calc")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\calc.wav"; player.Play();
                        Console.WriteLine("Calculadora Cerrada");
                        Console.WriteLine(); 
                    }


                    if (value.IndexOf("limpiar") != -1 || value.IndexOf("impiar") != -1)
                    {
                        Console.Clear();
                        Console.WriteLine("Hola, ¿Hay algo en lo que pueda ayudarte?");
                        Console.WriteLine(); 
                        player.SoundLocation = @"D:\asistente v.2.0\lim.wav"; player.Play();
                        
                    }

                    if (value.IndexOf("correo") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Rojas\Desktop\expo\emailfast.appref-ms");
                        Console.WriteLine();
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\correo.wav"; player.Play();
                    }
                    //nuevo
                       if (value.IndexOf("escritorio") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Rojas\Desktop");
                        Console.WriteLine();
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\esc.wav"; player.Play();
                    }
                  
                         if (value.IndexOf("prende") != -1)
                    {
                        System.Diagnostics.Process.Start(@"C:\Windows\System32\msconfig.exe");
                        Console.WriteLine();
                        player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\prende.wav"; player.Play();
                    }
                         if (value.IndexOf("temp") != -1)
                         {
                             System.Diagnostics.Process.Start(@"C:\Users\Rojas\AppData\Local\Temp");
                             Console.WriteLine();
                            
                         }

                         if (value.IndexOf("tt") != -1)
                         {
                             System.Diagnostics.Process.Start("https://twitter.com/");
                             Console.WriteLine();
                             player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\tt.wav"; player.Play();
                         }
                         if (value.IndexOf("dragon") != -1)
                         {
                             System.Diagnostics.Process.Start("http://dragonball.sullca.com/capitulos/dragon-ball-z/saga-majin-boo");
                             Console.WriteLine();
                             player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\dragon.wav"; player.Play();
                         }
                         if (value.IndexOf("super") != -1)
                         {
                             System.Diagnostics.Process.Start("http://animeflv.net/anime/dragon-ball-super.html");
                             Console.WriteLine();
                             player.SoundLocation = @"D:\asistente v.2.0\3.0\abresonido\super.wav"; player.Play();
                         }
                     
                    
                  

                    //partes de cortana

                    if (value.IndexOf("eres") != -1 && value.IndexOf("?") != -1)
                    {
                        player.SoundLocation = @"D:\asistente v.2.0\que.wav"; player.Play();
                        Console.WriteLine(); 


                    }
                   if (value.IndexOf("chiste") != -1)
                    {
                        player.SoundLocation = @"D:\asistente v.2.0\ch.wav"; player.Play();
                        Console.WriteLine(); 


                    }
                   if (value.IndexOf("que la fuerza te acompane") != -1 || value.IndexOf("que la fuerza te acompañe") != -1)
                    {
                        player.SoundLocation = @"D:\asistente v.2.0\f.wav"; player.Play();
                        Console.WriteLine(); 


                    }
                   if (value.IndexOf("recordar") != -1)
                   {
                       System.Diagnostics.Process.Start(@"C:\Users\Rojas\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Recordatorio\Recordatorio.appref-ms");
                       Console.WriteLine();
                   }



                } while (value.IndexOf("chau") == -1);
                player.SoundLocation = @"D:\asistente v.2.0\chau.wav"; player.Play();
                Console.ReadLine();
            }
        }
    }
}
