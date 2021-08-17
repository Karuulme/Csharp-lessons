using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hastane.Yonetimi.Models
{
    public class PatientRegistrationProduct
    {
        public string FirtName { get; set; }
        public string LastNameName { get; set; }
        public int Tc { get; set; }
        public int Tel { get; set; }
        public string Problem { get; set; }
        public string Status { get; set; }
        public string Area { get; set; }
        public string SelectDocker { get; set; }

    }
}