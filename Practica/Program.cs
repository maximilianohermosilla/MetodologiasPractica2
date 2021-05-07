﻿using System;

namespace Practica
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Coleccionable cola = new Cola<Comparable>();
			Coleccionable pila = new Pila<Comparable>();
		
			llenar(cola);
			informar(cola);
			llenar(pila);
			informar(pila);
			
			ColeccionMultiple multiple = new ColeccionMultiple(((Pila<Comparable>)pila), ((Cola<Comparable>)cola));
			informar(multiple);
			
			Coleccionable colaPersonas = new Cola<Comparable>();
			llenarPersonas(colaPersonas);
			Coleccionable pilaPersonas = new Pila<Comparable>();
			llenarPersonas(pilaPersonas);
			
			ColeccionMultiple multiplePersonas = new ColeccionMultiple(((Pila<Comparable>)pilaPersonas), ((Cola<Comparable>)colaPersonas));
			informar(multiplePersonas);
			
			Coleccionable colaAlumnos = new Cola<Comparable>();
			llenarAlumnos(colaAlumnos);
			Coleccionable pilaAlumnos = new Pila<Comparable>();
			llenarAlumnos(pilaAlumnos);
			
			ColeccionMultiple multipleAlumnos = new ColeccionMultiple(((Pila<Comparable>)pilaAlumnos), ((Cola<Comparable>)colaAlumnos));
			informar(multipleAlumnos);	

			Diccionario<Comparable> dictionary = new Diccionario<Comparable>();
			Numero number = new Numero(1);
			Numero number2 = new Numero(2);
			Console.WriteLine("Agrego 1, avion");
			dictionary.agregarClaveValor(number,"avion");
			Console.WriteLine("Agrego 1, casa");
			dictionary.agregarClaveValor(number,"casa");
			Console.WriteLine("Agrego 2, perro");
			dictionary.agregarClaveValor(number2,"perro");
			informar(dictionary);
			//Console.WriteLine(dictionary.valorDe(number));
			
			Console.ReadKey();
			
			
		}
		
		public static void llenar(Coleccionable lista){
			Random random = new Random();
			for (int x=1; x<=20 ; x++){
				Comparable numero = new Numero(random.Next(1,100));
				((Coleccionable)lista).agregar(numero);
			}
		}
		
		public static void informar(Coleccionable lista){
			try{
			Console.Write("Cantidad de elementos: ");
			Console.WriteLine(lista.cuantos());
			Console.Write("Mínimo: ");
			Console.WriteLine(lista.menor().informar());
			Console.Write("Máximo: ");
			Console.WriteLine(lista.mayor().informar());
			Console.Write("Ingrese número: ");
			string num = Console.ReadLine();
			if (lista.contieneNumero(num)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
			}
			}
			catch(FormatException){
				Console.WriteLine("* Numero invalido *");
				Console.ReadKey(true);
			}
		}
		
		public static void llenarPersonas(Coleccionable lista){
			Random random = new Random();
			string nombre;
			int dni;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			for (int x=1; x<=20 ; x++){
				nombre=nombres[random.Next(0,19)];
				dni=random.Next(12000000,40000000);
				Comparable persona = new Persona(nombre,dni);
				((Coleccionable)lista).agregar(persona);
				//Console.Write(((Persona)persona).getNombre() + " " + ((Persona)persona).getDni().ToString() + "\n");
			}
		}
		
		public static void llenarAlumnos(Coleccionable lista){
			Random random = new Random();
			string nombre;
			int dni, legajo;
			decimal promedio;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			for (int x=1; x<=20 ; x++){
				nombre=nombres[random.Next(0,19)];
				dni=random.Next(12000000,40000000);
				legajo=random.Next(1,2000);
				promedio=decimal.Round((Convert.ToDecimal((random.NextDouble() + random.Next(1,10)))), 2);
				Comparable alumno = new Alumno(nombre,dni,legajo,promedio);
				if (!lista.contiene(alumno)){
				    	((Coleccionable)lista).agregar(alumno);}
				else{
					//Console.WriteLine("Ya existe el alumno");
				}
				//Console.Write(((Alumno)alumno).getNombre() + " " + ((Alumno)alumno).getDni().ToString() + " " + ((Alumno)alumno).getLegajo() + " " + ((Alumno)alumno).getPromedio().ToString() + "\n");
			}
		}
	}
}