using System;

namespace Tarea
{

    public static class primerEjercicio
    {

        public static void Main()
        {

            string apellido;
            string categoria;

            int i, contadorSocios = 0, categoriaCont = 0;
            string categoriaMax = "declaration";

            string[] categorias = { "infantil", "juvenil", "adulto", "veterano" };
            int[] contadorCategorias = { 0, 0, 0, 0 };

            Console.Write("Apellido: ");
            apellido = Console.ReadLine();

            while (apellido.ToLower() != "salir" && contadorSocios <= 100000)
            {

                contadorSocios++;
                Console.Write("Nombre: ");
                Console.ReadLine();

                Console.Write("Dni: ");
                Console.ReadLine();

                Console.Write("Categoria: ");
                categoria = Console.ReadLine();

                for (i = 0; i < categorias.Length; i++)
                {
                    if (categorias[i] == categoria.ToLower())
                    {
                        contadorCategorias[i]++;
                    }
                }

                Console.Write("Apellido: ");
                apellido = Console.ReadLine();

            }

            for (i = 0; i < contadorCategorias.Length; i++)
            {
                if (contadorCategorias[i] > categoriaCont)
                {
                    categoriaCont = contadorCategorias[i];
                    categoriaMax = categorias[i];
                }
                    
            }

            Console.WriteLine("La cantidad total de socios es: " + contadorSocios);

            for(i = 0; i < categorias.Length; i++)
                Console.WriteLine("La cantidad total de socios de la categoria " + categorias[i] + " es: " + contadorCategorias[i]);

            for (i = 0; i < categorias.Length; i++)
                Console.WriteLine("La el promedio de la categoria " + categorias[i] + " es: " + ((float)contadorCategorias[i] / (float)contadorSocios));

            Console.WriteLine("La categoria con mas socios es: " + categoriaMax);

        }
    }
}