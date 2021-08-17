using Hastane.Yonetimi.Models;
using HospitalMssqlDataBase.MssqlDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBusiness.Buisness
{
    public class SelectDockerProductDal
    {
        public List<SelectDockerProduct> GetAll()
        {
            using (MssqlConnection context=new MssqlConnection())
            {

                return context.

            }


        }

    }
}
