using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public DateTime StaffDateAdded { get; set; }
        public string StaffUsername { get; set; }
        public string StaffPassword { get; set; }
        public int StaffSalary { get; set; }
        public string StaffRole { get; set; }
        public bool StaffMngr { get; set; }
    }
}