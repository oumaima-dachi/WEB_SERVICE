using System.Collections.Generic;
using System.Linq;

namespace WcfServiceEnseignement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceEnseignement" in both code and config file together.
    public class ServiceEnseignement : IServiceEnseignement
    {
        DataClassesEnseignemenDataContext dc = new DataClassesEnseignemenDataContext();

        public List<Eleve> GetByCNE(string cne)
        { 
            return (from eleve in dc.Eleves where eleve.CNE == cne select eleve).ToList(); 
        }
    }
}
