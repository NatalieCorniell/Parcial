using System;
using System.Collections.Generic;

namespace Partial
{
    class MainClass
    {
        private static List<string> _Contacts = new List<string>();

        public static void Main(string[] args)
        {
            bool Exit = false;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tAgendamiento de contactos telefonicos");
                Console.WriteLine("\t 1.Ingresar Contacto");
                Console.WriteLine("\t 2.Editar Contacto");
                Console.WriteLine("\t 3.Listar Contactos");
                Console.WriteLine("\t 4.Eliminar Contacto");
                Console.WriteLine("\t 5.Exit");

                Console.Write("\t Seleccione el numero segun la operacion deseada: ");
                int MenuPrincipal = Convert.ToInt32(Console.ReadLine());

                switch (MenuPrincipal)
                {
                    case 1:
                        FormAddContact();
                        break;
                    case 2:
                        FormEditContact();
                        break;
                    case 3:
                        FormListContact();
                        break;
                    case 4:
                        FormDeleteContact();
                        break;
                    case 5:
                        Exit = true;
                        break;
                }
                if (Exit == true)
                {
                    Console.WriteLine("\t\t Gracias por utilizar este sistema");
                    Console.ReadKey();

                    break;
                }
            }


        }

        private static void AddContact(List<string> ContactList, string contact)
        {
            ContactList.Add(contact);
        }
        private static void ShowContact()
        {
            int index = 1;
            foreach (string Contact in _Contacts)
            {
                Console.WriteLine(index + " - " + Contact);
                index++;
            }
        }
        private static void EditContact<T>(List<T> ContactLis, int index, T contact)
        {
            ContactLis[index] = contact;
        }
        private static void DeleteContact(List<string> contactsList, int contact)
        {
            contactsList.RemoveAt(contact);
        }

        private static void FormAddContact()
        {
            Console.Write("\t Nombre: ");
            string ContactName = Console.ReadLine();
            Console.Write("\t Apellido: ");
            string ContactLastName = Console.ReadLine();
            Console.Write("\t Numero de Telefono: ");
            string ContactNumber = Console.ReadLine();

            string Con = "Nombre: " + ContactName + "\n" + "Apellido: " + ContactLastName + "\n" + "Numero telefonico: " + ContactNumber;
            AddContact(_Contacts, Con);
            Console.Write("\t Contacto guardado!");
            Console.ReadKey();

        }
        private static void FormEditContact()
        {

            if (_Contacts.Count == 0)
            {

                Console.WriteLine("\t\t Lista de contactos vacia \n");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("\t Seleccione el contacto que desea editar \n");

                ShowContact();

                int NewContact = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.Write("\t\t Ingrese los nuevos valores \n");
                Console.Write("\t Nombre:");
                string NewName = Console.ReadLine();
                Console.Write("\t Apellido:");
                string NewLastName = Console.ReadLine();
                Console.Write("\t Numero telefonico:");
                string NewContactNumber = Console.ReadLine();

                string Con = "Nombre: " + NewName + "\n" + "Apellido: " + NewLastName + "\n" + "Numero telefonico: " + NewContactNumber;

                EditContact(_Contacts, (NewContact - 1), Con);
                Console.WriteLine("\t\t Contacto editado !\n");

                ShowContact();
                Console.ReadKey();
            }

        }
        private static void FormListContact()
        {
            if (_Contacts.Count == 0)
            {
                Console.WriteLine("\t Aun no existe ningun contacto para editar: \n");
            }
            else
            {
                Console.WriteLine("\t Estos son los contactos a listar: \n");
                ShowContact();
            }
            Console.ReadKey();
        }
        private static void FormDeleteContact()
        {
            if (_Contacts.Count == 0)
            {
                Console.WriteLine("\t\t Lista de Contactos vacia");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("\t Seleccione el contacto que desea eliminar \n");
                ShowContact();
                int Contact = Convert.ToInt32(Console.ReadLine());
                DeleteContact(_Contacts, (Contact - 1));

                Console.WriteLine("\t Contacto eliminado \n");

                ShowContact();
                Console.ReadKey();

            }

        }

       
    }
}

