using System.Collections;
using System;

namespace Practica_3

{
	class Program
	{
		
    		 static void Main (string[] args)
    		 	 {
    		 	 
    		 	 
    		 	 Console.WriteLine("práctica 3 hash table");
    		 	 
    		 	 
    		 	 
					 Hashtable p= new Hashtable ();
					 p.Add (1, "Juan");
					 p.Add (2, "José");
					 p.Add (3, "Mario");
					
					  foreach (int key in p. Keys)
							 {
							     Console.WriteLine(key);
							 }
	 
											 Console.WriteLine("\n"); 
					  
					 foreach (string value in p. Values )
							 {
							     Console.WriteLine(value);
							 }
											  Console.WriteLine("\n"); 
									 
					 
					  Console.WriteLine("Seleccione el movimiento que desea realizar; \n\n\t 1) Revisar una persona \n\t 2) " +
					                   "Eliminar una persona \n\t 3) Editar una persona");
					 
					  int opc = int.Parse (Console.ReadLine());
					 
														  Console.WriteLine("\n \n");
					   
						switch (opc)
		           			 {
				                case 1: 
									
									string nom;
									Console.WriteLine ("escribe el nombre de la persona a revisar \n");
									nom=Console.ReadLine();
									
								
									if (p.ContainsValue (nom))
							          	{
							          	   Console.WriteLine ("Este nombre ya está en la lista");
							          	}
							  		else 
							  			{
							  			   Console.WriteLine ("Este nombre no está en la lista");
							  			}
					  			break;
					  		
				                case 2: Console.Write("escribe el número de la persona a eliminar \n");
				                		{
				                			 int num = int.Parse (Console.ReadLine());
				                			 p.Remove (num);
				                		}
								                
				                				foreach (int key in p. Keys )
													 {
													     Console.WriteLine(key);
													 }
				
					 
													 Console.WriteLine("\n"); 
												  
											    foreach (string value in p. Values )
													 {
													     Console.WriteLine(value);
													 }
														  Console.WriteLine("\n"); 
				                
				                
				                        break;
				                
				                        
				                        
				                        
				                        
				                        case 3: 
					                		{
					                			
												Console.WriteLine ("escribe el número de la persona a editar \n");
												
												int num = int.Parse (Console.ReadLine());
				                			 
							
													p.Remove (num);
												
												string nomb;
								             	Console.WriteLine ("escribe el nuevo nombre \n");
												nomb=Console.ReadLine();
												
												p.Add (4,nomb);
												
											}

				                       foreach (int key in p. Keys )
													 {
													     Console.WriteLine(key);
													 }
				
					 
													 Console.WriteLine("\n"); 
												  
											    foreach (string value in p. Values )
													 {
													     Console.WriteLine(value);
													 }
														 Console.WriteLine("\n"); 
				                        
				                        break;
							
					  }
					 
					 
					  Console.WriteLine("\n \n"); 
					  Console.WriteLine("\n \n"); 
								 
					 Console.Write("Press any key to continue . . . ");
					 Console.ReadKey(true);
				}
		}
	}
