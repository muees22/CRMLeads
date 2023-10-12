using System.Data.SqlClient;

namespace CRMLeads.Data

{
    public class LeadRepository
    {
        private SqlConnection _connection;

        public LeadRepository()
        {
            //string connStr = "Server ..... Database ...... ; TrustedConnection= True; ......"
        }
    }
}
