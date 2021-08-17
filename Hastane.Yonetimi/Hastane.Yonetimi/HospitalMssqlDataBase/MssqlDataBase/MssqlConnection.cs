using Hastane.Yonetimi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMssqlDataBase.MssqlDataBase
{
    public class MssqlConnection:DbContext
    {
        DbSet<SelectDockerProduct> selectDockerProducts { get; set; }
        DbSet<PatientRegistrationProduct> patientRegistrationProduct { get; set; }
        DbSet<SearchProduct> searchProduct { get; set; }
    }
}
