
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Conversation_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ConversationCEN
{
public int New_ (Nullable<DateTime> p_startDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> p_message, int p_practitioner)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Conversation_new__customized) START*/

        ConversationEN conversationEN = null;

        int oid;

        //Initialized ConversationEN
        conversationEN = new ConversationEN ();
        conversationEN.StartDate = p_startDate;

        conversationEN.Message = p_message;


        if (p_practitioner != -1) {
                conversationEN.Practitioner = new ChroniGenNHibernate.EN.Chroni.PractitionerEN ();
                conversationEN.Practitioner.Identifier = p_practitioner;
        }

        //Call to ConversationCAD

        oid = _IConversationCAD.New_ (conversationEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
