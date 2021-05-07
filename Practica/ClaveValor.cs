﻿using System;

namespace Practica
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor: Comparable
	{
		Comparable clave;
		Object valor;
		
		public ClaveValor(Comparable clave, Object valor){
			this.clave=clave;
			this.valor=valor;
		}
		
		public void setValor(Object valor){
			this.valor=valor;
		}
			
		public Comparable getClave(){
			return clave;
		}
		
		public Object getValor(){
			return valor;
		}
	
		public bool sosIgual(Comparable obj){
			bool esIgual=false;
			if (clave==((ClaveValor)obj).getClave()){
				esIgual=true;
		}
			return esIgual;
		}
		
		public bool sosMenor(Comparable obj){
			bool esMenor=false;
			/*if (valor<((ClaveValor)obj).getValor()){
				esMenor=true;
		}*/
			return esMenor;
		}
		
		public bool sosMayor(Comparable obj){
			bool esMayor=false;
			/*if (valor>((ClaveValor)obj).getValor()){
				esMayor=true;
		}*/
			return esMayor;
		}
		
		public string informar(){
			return this.ToString();
		}
		
		public override string ToString()
		{
			return string.Format("{0},{1}", valor,clave);
		}
		
	}
}
