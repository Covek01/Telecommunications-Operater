using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Telekomunikacija
{
    internal class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock=new object();
        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock(objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }
            return _factory.OpenSession();
        }




        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10.ConnectionString(c => c.Is(
                        "Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18430;Password=LepJeGradSamarkand"));

                return Fluently.Configure()
                        .Database(cfg)
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Telekomunikacija.Mapiranje.UgovorMapiranje>())
                        .BuildSessionFactory();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "EXCEPTION");
                throw;
            }
        }
    }
}
