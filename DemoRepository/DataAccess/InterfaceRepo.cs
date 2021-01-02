using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.Model;

namespace DemoRepository.DataAccess
{
 public   interface InterfaceRepo
    {

        void Insert_record(XpayDetails xp);

        void Dlt_Record(XpayDetails xp);

        void Update_Record(XpayDetails xp);

        List<XpayDetails> Show_Record();


    }
}
