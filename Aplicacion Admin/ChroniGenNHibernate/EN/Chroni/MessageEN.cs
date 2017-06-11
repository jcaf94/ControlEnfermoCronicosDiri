
using System;
// Definición clase MessageEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class MessageEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo date
 */
private Nullable<DateTime> date;



/**
 *	Atributo content
 */
private string content;



/**
 *	Atributo isRead
 */
private bool isRead;



/**
 *	Atributo conversation
 */
private ChroniGenNHibernate.EN.Chroni.ConversationEN conversation;



/**
 *	Atributo attachment
 */
private string attachment;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual Nullable<DateTime> Date {
        get { return date; } set { date = value;  }
}



public virtual string Content {
        get { return content; } set { content = value;  }
}



public virtual bool IsRead {
        get { return isRead; } set { isRead = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.ConversationEN Conversation {
        get { return conversation; } set { conversation = value;  }
}



public virtual string Attachment {
        get { return attachment; } set { attachment = value;  }
}





public MessageEN()
{
}



public MessageEN(int identifier, Nullable<DateTime> date, string content, bool isRead, ChroniGenNHibernate.EN.Chroni.ConversationEN conversation, string attachment
                 )
{
        this.init (Identifier, date, content, isRead, conversation, attachment);
}


public MessageEN(MessageEN message)
{
        this.init (Identifier, message.Date, message.Content, message.IsRead, message.Conversation, message.Attachment);
}

private void init (int identifier
                   , Nullable<DateTime> date, string content, bool isRead, ChroniGenNHibernate.EN.Chroni.ConversationEN conversation, string attachment)
{
        this.Identifier = identifier;


        this.Date = date;

        this.Content = content;

        this.IsRead = isRead;

        this.Conversation = conversation;

        this.Attachment = attachment;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MessageEN t = obj as MessageEN;
        if (t == null)
                return false;
        if (Identifier.Equals (t.Identifier))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Identifier.GetHashCode ();
        return hash;
}
}
}
