using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RECSClimate
{
    public class Contributor
    {
        [PrimaryKey, AutoIncrement]
        
        public int ContributorID { get; set; }
        public string contributorName { get; set; }
        public Byte[] contributorPicture { get; set; }
        public string contributorAddress { get; set; }
        public string contributorCity { get; set; }
        public string contributorZipcode { get; set; }
        public string contributorPhoneNumber { get; set; }
        public string contributorEmail { get; set; }
        public string contributorDescription { get; set; }
    }

}
