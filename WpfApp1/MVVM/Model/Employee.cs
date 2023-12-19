using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.MVVM.Core;

namespace WpfApp1.MVVM.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int PositionID { get; set; }

        public virtual Position Position { get; set; }

        [NotMapped]
        public Position EmployeePosition
        {
            get
            {
                return DataWorker.GetPositionByID(PositionID);
            }
        }
    }
}
