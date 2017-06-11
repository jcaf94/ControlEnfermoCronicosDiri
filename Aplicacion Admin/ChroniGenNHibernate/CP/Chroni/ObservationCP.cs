
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
public partial class ObservationCP : BasicCP
{
public ObservationCP() : base ()
{
}

public ObservationCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
