using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Library_NETCore_st_proj.Models
{
    public class BooksShared
    {
        public int ID { get; set; }
        public DateTime DateShared { get; set; }
        public int ClientID { get; set; }
        public int BooksID { get; set; }

    }
}
