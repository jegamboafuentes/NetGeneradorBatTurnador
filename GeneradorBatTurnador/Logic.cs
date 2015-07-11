using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GeneradorBatTurnador
{
    class Logic
    {

        public string GeneraBat(string sucursal)
        {
            string ceros = AcomodaCeros(Int32.Parse(sucursal));
            string codigo = "";
            string pathGoogle32 = @"C:\Program Files\Google\Chrome\Application";
            string pathGoogle64 = @"C:\Program Files (x86)\Google\Chrome\Application";
            if (Environment.Is64BitOperatingSystem)
            {
                if (Directory.Exists(pathGoogle64) == true)
                {
                    int sucursalTransf = Int32.Parse(sucursal);
                    //codigo = "timeout /t 15\n\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\" --chrome-frame --kiosk http://nt" + ceros + sucursalTransf + "/BazCajaFront/Display/Default.aspx";
                    codigo = "start cmd /c \"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"" + "\r\n" + "timeout /t 5" + "\r\n" + "taskkill /IM chrome.exe" + "\r\n" + "timeout /t 30" + "\r\n" + "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\" --chrome-frame --kiosk http://nt" + ceros + sucursalTransf + "/BazCajaFront/Display/Default.aspx";
                    CreaBat(codigo);
                    return codigo;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la ruta de Google Chrome\nAsegurese que este bien instalado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return "Error";
                }
                
            }
            else
            {
                if (Directory.Exists(pathGoogle32) == true)
                {
                    int sucursalTransf = Int32.Parse(sucursal);
                    //codigo = "timeout /t 15/n\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\" --chrome-frame --kiosk http://nt" + ceros + sucursalTransf + "/BazCajaFront/Display/Default.aspx";
                    codigo = "start cmd /c \"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"" + "\r\n" + "timeout /t 5" + "\r\n" + "taskkill /IM chrome.exe" + "\r\n" + "timeout /t 30" + "\r\n" + "\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\" --chrome-frame --kiosk http://nt" + ceros + sucursalTransf + "/BazCajaFront/Display/Default.aspx";
                    CreaBat(codigo);
                    return codigo;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la ruta de Google Chrome\nAsegurese que este bien instalado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return "Error";
                }
            }
        }

        public void CreaBat(string bat)
        {
            string newPath;
            try
            {
                string path = @"C:\Users\B993241\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup";
                if (Directory.Exists(path) == true)
                {
                    FileStream stream = new FileStream("C:\\Users\\" + SystemInformation.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Turnador.bat", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(bat);
                    writer.Close();
                }else
                {
                    int i = 0;
                    char[] unidadX = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
                    do
                    {
                        newPath = unidadX[i] + ":\\Users\\" + SystemInformation.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";
                        i++;
                    } while (Directory.Exists(newPath) == false);
                    FileStream stream = new FileStream(newPath + "\\Turnador.bat", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(bat);
                    writer.Close();

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo crear el archivo .bat en la carpeta inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public bool BuscaServidor(string url)
        {
                try
                {
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    request.Method = "GET";
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    return (true);
                }
                catch
                {
                    return false;
                }
            



        }

        public bool BuscarServidorAutomatico(int numeroServidor)
        {

            string ceros = AcomodaCeros(numeroServidor);
            
            if (BuscaServidor("http://nt"+ceros+numeroServidor+"/BazCajaFront/Servicios/Turnador/CjCRNegocioService.svc/negocio/") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AcomodaCeros(int numero)
        {
            string ceros;

                if (numero < 10)
                {
                    ceros =  "000";
                }
                else if (numero < 100)
                {
                    ceros =  "00";
                }
                else if (numero < 1000)
                {
                    ceros =  "0";
                }
                else
                {
                    ceros =  "";
                }
                return ceros;
                 
        }

        public bool validaInformacion(string numero)
        {
            try
            {
                if (Int32.Parse(numero) <= 9999)
                {
                    return true;
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string ValidaCantidadCeros(string numero)
        {
            char[] numeros = numero.ToCharArray();
            char[] nuevaCadena = new char[4];
            string nuevoNumero = new string(nuevaCadena);
            try
            {

                if (numeros[0] == '0' && numeros[1] == '0' && numeros[2] == '0')
                {
                    nuevaCadena[0] = numeros[3];
                }
                else if (numeros[0] == '0' && numeros[1] == '0')
                {
                    nuevaCadena[1] = numeros[3];
                    nuevaCadena[0] = numeros[2];
                }
                else if (numeros[0] == '0')
                {
                    nuevaCadena[2] = numeros[3];
                    nuevaCadena[1] = numeros[2];
                    nuevaCadena[0] = numeros[1];
                }
                else { return numero; }
                return nuevoNumero;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo esta mal ;(");
                return "error";
                
            }


        }

        

    }
}
