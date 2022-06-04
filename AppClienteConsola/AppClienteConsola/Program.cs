/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppClienteConsola
{
    class Program
    {
        static void Main (string[] args)
        {
            string url = "http://localhost:9090/api/inventario";
            ListarElementos(url);
        }
        static void ListarElementos(string url)
        {
            using (HttpClient cliente = new HttpClient())
            {
                using (HttpRequestMessage solicitud = new HttpRequestMessage())
                {   //creando solicitudes
                    solicitud.RequestUri = new Uri(url);   
                    solicitud.Method = HttpMethod.Get;
                    solicitud.Headers.Add("Accept", "application/json");

                    //respuesta de la solicitudd
                    Task<HttpResponseMessage> httpResponse = cliente.SendAsync(solicitud);
                    using (HttpResponseMessage respuesta = httpResponse.Result)
                    {
                        //obtener contenido (puede ser stream o texto, y si es necesario transformarlo a objetos)
                        Console.WriteLine(respuesta.ToString());
                        HttpStatusCode codigo = respuesta.StatusCode;
                        Console.WriteLine("Estado {0}", codigo);  
                        Console.WriteLine("codigo {0}", (int)codigo);
                        HttpContent contenido = respuesta.Content;
                        Task<string> datos =contenido.ReadAsStringAsync();
                        string cadena = datos.Result;
                        Console.WriteLine(cadena);
                    }

                }
            }
        }
    }
}
