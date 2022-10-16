using System;
using WhatsAppApiUCU;
namespace Library;

public class WhatsAppMessage : IMessageChannel
{
    public static void Send(Message message)
    {
        var selectedContacts = message.From.Search(message.To);
        foreach (Contact contact in selectedContacts)
        {
            Console.WriteLine(contact.Name);
            var whatsApp = new WhatsAppApi();
            string sid = whatsApp.Send(contact.Phone, message.Text);
            Console.WriteLine(sid);
        } 
    }
}