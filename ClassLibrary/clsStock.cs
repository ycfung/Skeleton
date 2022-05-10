using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStock
    {
        private int id;
        private string name;
        private int quantity;
        private string type;
        private string remark;
        private string time;
        private bool available;
        private static readonly List<string> types = new List<string>
            { "Food","Utils","Others"};

        public clsStock() { }

        public clsStock(int id, string name, int quantity, string type, string remark, string time, bool available)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.type = type;
            this.remark = remark;
            this.time = time;
            this.available = available;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public bool Find(int stockID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", stockID);
            DB.Execute("sproc_tblStock_FilterById");
            if (DB.Count == 1)
            {
                id = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                name = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                quantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                type = Convert.ToString(DB.DataTable.Rows[0]["Type"]);
                remark = Convert.ToString(DB.DataTable.Rows[0]["Remark"]);
                time = Convert.ToString(DB.DataTable.Rows[0]["Time"]);
                available = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                return true;
            }
            else return false;
        }

        public string Type { get => type; set => type = value; }
        public string Remark { get => remark; set => remark = value; }
        public string Time { get => time; set => time = value; }
        public bool Available { get => available; set => available = value; }

        public string Valid(string id, string name, string quantity, string type, string remark, string time)
        {
            String Error = "";

            if (id.Length == 0)
                Error += "Id should not be blank : ";
            else if (!int.TryParse(id, out _))
                Error += "Id should be a number : ";
            else if (Int32.Parse(id) <= 0)
                Error += "Id should be a negative number : ";

            if (name.Length > 20)
                Error += "The length of name is greater than 20 : ";
            else if (name.Length == 0)
                Error += "Name should not be blank : ";

            if (!int.TryParse(quantity, out _))
                Error += "The quantity should be a number";
            else if (Int32.Parse(quantity) > 500)
                Error += "The quantity should not be more than 500 : ";
            else if (Int32.Parse(quantity) <= 0)
                Error += "The quantity should be a positive number : ";

            if (type.Length == 0)
                Error += "Type should not be blank : ";
            else if (!types.Contains(type))
                Error += "The type should be Food, Utils or Others : ";

            if (remark.Length > 50)
                Error += "Remark is too long : ";

            if (time.Length == 0) { }
            else if (!DateTime.TryParse(time, out _))
                Error += "Time is invalid : ";

            return Error;
        }
    }
}
