using System;
using WhatsAppApiUCU;
namespace Library;

public class WhatsApp : Message
{
    public WhatsApp(Phonebook from, string[] to) : base (from, to)
    {
        
    }
}