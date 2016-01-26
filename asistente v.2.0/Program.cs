
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

using System.Threading.Tasks;
    using System.Diagnostics;

namespace System.Diagnostics
{
    namespace ConsoleApplication1
    {
        class Program
        {
            static void Main(string[] args)
            {
                string Fecha = "", hora = "";
                string opc, opc2, text = " ";
                string rpt;
                int convers = 2;
                SoundPlayer player = new SoundPlayer();


                player.SoundLocation = @"D:\asistente v.2.0\Dwm 2015 06 22 14 39 56 44.wav"; player.Play();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bienvenido Amo, escriba lo que desee que haga : ");

               
                
               

                do
                {
                    Console.WriteLine("");
                    opc = Console.ReadLine();

                    if (opc == "cual es tu edad?")
                    {

                        rpt = "No tengo edad ,soy una macquina :v";
                        Console.WriteLine(rpt);
                    }
                    if (opc == "buscar google")
                    {
                        
                        string ee;
                        player.SoundLocation = @"D:\asistente v.2.0\g.wav"; player.Play();
                        Console.WriteLine("Escriba lo que desee buscar en google: ");
                        Console.WriteLine();  
                        ee = Console.ReadLine();

                        System.Diagnostics.Process.Start("https://www.google.com.pe/search?q=" + ee);
                        player.SoundLocation = @"D:\asistente v.2.0\b.wav"; player.Play();


                    }
                
                    if (opc == "buscar youtu")
                    {
                        string yu;
                        player.SoundLocation = @"D:\asistente v.2.0\y.wav"; player.Play();
                        Console.WriteLine("Escriba lo que desee buscar en youtube: ");
                        Console.WriteLine();  
                        yu = Console.ReadLine();
                        System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + yu);
                        player.SoundLocation = @"D:\asistente v.2.0\b.wav"; player.Play();


                    }


                    if (opc == "ricardo es pisado?")
                    {
                        player.SoundLocation = @"D:\asistente v.2.0\pisado.wav"; player.Play();
                        rpt = "Por su puesto xd";
                        Console.WriteLine(rpt);


                    }

                    if (opc == "dime la fecha" || opc == "dime a fecha")
                    {
                        Console.Write("La fecha es: ");
                        Fecha = DateTime.Now.ToString("dd/MM/yyyy");
                        Console.WriteLine(Fecha);
                    }
                    if (opc == "dime a temperatura" || opc == "dime la temperatura")
                    {
                        player.SoundLocation = @"D:\asistente v.2.0\bus.wav"; player.Play();
                        Console.WriteLine("Buscando en google");
                        System.Diagnostics.Process.Start("https://www.google.com.pe/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=la%20temperatura%20en%20lima%20es");
                        player.SoundLocation = @"D:\asistente v.2.0\listo.wav"; player.Play();
                        Console.WriteLine("Listo");
                    }


                    if (opc == "abre google")
                    {
                        System.Diagnostics.Process.Start("https://www.google.com.pe/");
                    }

                    if (opc == "abre face")
                    {
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }

                    if (opc == "abre youtu")
                    {
                        System.Diagnostics.Process.Start("https://www.youtube.com.pe/");
                    }

                    if (opc == "abre wpp")
                    {
                        System.Diagnostics.Process.Start("https://web.whatsapp.com/");
                    }

                    if (opc == "abre descargas")
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Rojas\Documents\Downloads");
                    }

                    if (opc == "dime la hora" || opc == "dime a hora")
                    {

                        //String.Format("{0:HH:mm:ss}");
                        Console.Write("La hora es: ");
                        hora = DateTime.Now.ToString("HH:mm:ss");
                        Console.WriteLine(hora);
                    }


                    if (opc == "abre d")
                    {
                        System.Diagnostics.Process.Start(@"D:\");
                    }

                    if (opc == "abre fotos")
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Rojas\OneDrive para la Empresa\Fotos");
                        System.Diagnostics.Process.Start(@"C:\Users\Rojas\OneDrive para la Empresa\Camera");
                    }
                    if (opc == "abre sao")
                    {
                        System.Diagnostics.Process.Start("http://animeflv.net/anime/sword-art-online-2.html");
                    }
                    if (opc == "abre musica")
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Rojas\AppData\Roaming\Spotify\spotify.exe");
                    }
                    
                               if (opc == "cerrar musica")
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
                    }
                    if (opc == "abre sony")
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Sony\Vegas Pro 11.0\vegas110.exe");
                    }
                    
                              if (opc == "cerrar sony")
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
                    }
                    if (opc == "abre word")
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office14\WINWORD.exe");
                    }
                    
                          if (opc == "cerrar word")
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
                    }
                    if (opc == "abre exel")
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office14\EXCEL.exe");
                    }
                    
                               if (opc == "cerrar exel")
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
                    }
                    if (opc == "abre ppt")
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office14\POWERPNT.exe");
                    }
                      if (opc == "cerrar ppt")
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
                    }
                   
                    if (opc == "abre cc")
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Visual Studio 10.0\Common7\IDE\vcsexpress.exe");
                    }
                    if (opc == "cerrar cc")
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
                    }

                    if (opc == "abre counter")
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Counter-Strike 1.6\hl.exe");
                    }
                    if (opc == "abre notas")
                    {
                        System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
                    }
                     if (opc == "cerrar notas")
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
                    }
                  
                    if (opc == "abre minecraft")
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Public\Music\Escritorio\.minecraft\minecraft launcher\Minecraft Launcher.exe");
                    }
                    
                          if (opc == "cerrar minecraft")
                    {
                        foreach (Process proceso in Process.GetProcesses())
                        {
                            if (proceso.ProcessName == "javaw")
                            {
                                proceso.Kill();
                            }

                        }
                        player.SoundLocation = @"D:\asistente v.2.0\mi.wav"; player.Play();
                        Console.WriteLine("miecraft Cerrado");  
                    }

                    if (opc == "abre opera")
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Opera\launcher.exe");
                    }
                    if (opc == "cerrar opera")
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
                    }

                    if (opc == "abre calc")
                    {
                        System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
                    }
                    if (opc == "cerrar calc")
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
                    }


                    else if (opc == "limpiar" || opc == "impiar")
                    {
                        Console.Clear();
                        Console.WriteLine("Bienvenido Amo, escriba lo que desee : ");
                        player.SoundLocation = @"D:\asistente v.2.0\lim.wav"; player.Play();
                        
                    }


                } while (opc != "chau");
                player.SoundLocation = @"D:\asistente v.2.0\chau.wav"; player.Play();
                Console.ReadLine();
            }
        }
    }
}
