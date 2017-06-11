
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using ChroniGenNHibernate.Exceptions;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;
using ChroniGenNHibernate.CEN.Chroni;



namespace ChroniGenNHibernate.CP.Chroni
{
public partial class PatientCP : BasicCP
{
public PatientCP() : base ()
{
}

public PatientCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
