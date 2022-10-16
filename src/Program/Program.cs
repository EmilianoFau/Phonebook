using System;
using Library;
using System.Collections.Generic;
using TwitterUCU;
using WhatsAppApiUCU;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contact1 = new Contact("Emiliano");
            Phonebook owner = new Phonebook(contact1);

            // Agregar contactos a la lista
            Contact contact2 = new Contact("Lucas");
            contact2.Phone = "+59892301894";
            contact2.Email = "1581773205886451716";
            owner.AddContact(contact2);

            Contact contact3 = new Contact("Lucia");
            contact3.Phone = "+59898370230";
            owner.AddContact(contact3);

            Contact contact4 = new Contact("Matilde");
            contact4.Phone = "+59899888555";
            owner.AddContact(contact4);

            // Crear la lista de contactos
            string[] Contacts = new string[3];
            Contacts[0] = "Lucas";
            Contacts[1] = "Lucia";
            Contacts[2] = "Matilde";

            // Enviar un mensaje de Twitter a algunos contactos
            Message mensajeT = new Twitter(owner, Contacts);
            mensajeT.Text = "hola, cómo estás?";
            MessageTwitter.Send(mensajeT);         

            // Enviar un WhatsApp a algunos contactos
            Message mensajeW = new WhatsApp(owner, Contacts);
            mensajeW.Text = "hola, cómo estás?";
            WhatsAppMessage.Send(mensajeW);
        }
    }
}
