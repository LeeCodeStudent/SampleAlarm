using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AlarmHistoryModel
    {
        [DisplayName("序号")]
        public int AlarmIndex { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string State { get; set; }

        public int Value { get; set; }

        public string Unit { get; set; }

        public DateTime UTC { get; set; }

    }
}
