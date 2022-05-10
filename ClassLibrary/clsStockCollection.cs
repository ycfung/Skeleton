using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{



    class clsStockCollection
    {
        private List<clsStock> StockList;
        private Int32 Count;
        private clsStock ThisStock;

        public Int32 Add()
        {
            return 0;
        }

        public void Delete()
        {

        }

        public void ReportByType(string Type)
        {

        }

        public void Update()
        {

        }

        public clsStockCollection(List<clsStock> stockList, int count, clsStock thisStock)
        {
            StockList1 = stockList;
            Count1 = count;
            ThisStock1 = thisStock;
        }

        public clsStockCollection()
        {
        }

        public List<clsStock> StockList1 { get => StockList; set => StockList = value; }
        public int Count1 { get => Count; set => Count = value; }
        public clsStock ThisStock1 { get => ThisStock; set => ThisStock = value; }
    }
}
