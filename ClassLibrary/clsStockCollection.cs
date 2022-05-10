using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{



    public class clsStockCollection
    {
        List<clsStock> stockList = new List<clsStock>();
        Int32 count;
        clsStock thisStock = new clsStock();


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", ThisStock.Id);
            DB.AddParameter("@name", ThisStock.Name);
            DB.AddParameter("@quantity", ThisStock.Quantity);
            DB.AddParameter("@type", ThisStock.Type);
            DB.AddParameter("@Time", ThisStock.Time);
            DB.AddParameter("@available", ThisStock.Available);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", ThisStock.Id);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByType(string Type)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Type", Type);
            DB.Execute("sproc_tblStock_FilterByType");
            this.stockList = new List<clsStock>();
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Id = Convert.ToString(DB.DataTable.Rows[Index]["Id"]);
                AnStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                AnStock.Type = Convert.ToString(DB.DataTable.Rows[Index]["type"]);
                AnStock.Remark = Convert.ToString(DB.DataTable.Rows[Index]["remark"]);
                AnStock.Time = Convert.ToString(DB.DataTable.Rows[Index]["Time"]);
                AnStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["available"]);
                this.stockList.Add(AnStock);
                Index++;
            }
        }



        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", ThisStock.Id);
            DB.AddParameter("@name", ThisStock.Name);
            DB.AddParameter("@quantity", ThisStock.Quantity);
            DB.AddParameter("@type", ThisStock.Type);
            DB.AddParameter("@Time", ThisStock.Time);
            DB.AddParameter("@available", ThisStock.Available);
            DB.Execute("sproc_tblStock_Update");

        }

        public clsStockCollection()
        {
            this.stockList = new List<clsStock>();
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Id = Convert.ToString(DB.DataTable.Rows[Index]["Id"]);
                AnStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                AnStock.Type = Convert.ToString(DB.DataTable.Rows[Index]["type"]);
                AnStock.Remark = Convert.ToString(DB.DataTable.Rows[Index]["remark"]);
                AnStock.Time = Convert.ToString(DB.DataTable.Rows[Index]["Time"]);
                AnStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["available"]);
                this.stockList.Add(AnStock);
                Index++;
            }
        }

        public clsStockCollection(List<clsStock> stockList, int count, clsStock thisStock)
        {
            this.stockList = stockList;
            this.count = count;
            this.thisStock = thisStock;
        }

        public List<clsStock> StockList { get => stockList; set => stockList = value; }
        public int Count { get => StockList.Count; set => count = value; }
        public clsStock ThisStock { get => thisStock; set => thisStock = value; }

    }
}
