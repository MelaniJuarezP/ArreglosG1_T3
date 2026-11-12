using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //atributos o campos
        private int _tope;
        private int[] _arreglo;

        //constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }

        //propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //etodo llenar sin parametro
        public void Llenar()
        {
            Llenar(1, 100);
        }

        //métodos llenar con parametro
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }
            _tope = N;
        }

        //metodo ordenar (burbuja)
        public void Ordenar()
        {
            Ordenar(true);//si no tiene parametro, lo hace ascendente
        }
        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope; i++) 
            {
                for (int j = i+1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else 
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    
                }
            }
        }
        
        //metodo cambiar
        public void Cambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        //metodo agregar
        public void Agregar(int numero)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            _arreglo[_tope] = numero;
            _tope++;
        }

        //metodo insertar
        public void Insertar(int numero, int posicion)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }

            for (int i = _tope; i > posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1];
            }
            _arreglo[posicion] = numero;
            _tope++;
        }

        //metodo eliminar
        public void Eliminar(int posicion)
        {
            if (EstaVacio)
            {
                throw new Exception("El arreglo esta vacio");
            }
            if (posicion < 0)
            {
                posicion=0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = posicion; i < _tope-1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;
        }

        //metodo pares
        public MiArreglo ObtenerPares()
        {
            int contadorPares = 0;
            for (int i = 0; i < _tope; i++)
            {
                if (EsPar(_arreglo[i]))
                {
                    contadorPares++;
                }
            }

            var arregloPares = new MiArreglo(contadorPares);
            for (int i = 0; i < _tope; i++)
            {
                if (EsPar(_arreglo[i]))
                {
                    arregloPares.Agregar(_arreglo[i]);
                }

            }

            return arregloPares;
        }

        //metodo EsPar
        private bool EsPar(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
        //Metodo obtener primos

        public MiArreglo ObtenerPrimos()
        {
            int contadorPrimos = 0;
            for (int i = 0; i < _tope; i++)
            {
                if(_arreglo[i]==1){ continue; }//salta a la siguiente iteración
                if (EsPrimo(_arreglo[i]))
                {
                    contadorPrimos++;
                }
            }
            var arregloPrimos = new MiArreglo(contadorPrimos);
            for (int i = 0; i < _tope; i++)
            {
                if (_arreglo[i] == 1) { continue; }//salta a la siguiente iteración
                if (EsPrimo(_arreglo[i]))
                {
                    arregloPrimos.Agregar(_arreglo[i]);
                }

            }
            return arregloPrimos;
        }
        //metodo EsPrimo
        private bool EsPrimo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return true;
        }


        //método ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "Esta vacio";
            }

            int contador = 0;
            string cadena =string.Empty;
            for (int i = 0; i < _tope; i++)
            {
                //cadena = cadena+_arreglo[i];
                cadena += $"{_arreglo[i]}\t";
                contador++;
                if (contador > 9)
                {
                    contador = 0;
                    cadena += "\n";
                }
            }
            return cadena;

        }
    }
}
