using System;
using TwitterUCU;
namespace Library;

public class MessageTwitter : IMessageChannel
{
    public static void Send(Message message)
    {
        var selectedContacts = message.From.Search(message.To);
        foreach (Contact contact in selectedContacts)
        {
            Console.WriteLine(contact.Name);
            var twitterDirectMessage = new TwitterMessage();
            Console.WriteLine(twitterDirectMessage.SendMessage(message.Text, contact.Email));        
        } 
    }
}