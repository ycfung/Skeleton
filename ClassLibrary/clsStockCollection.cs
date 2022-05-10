using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{



    public class clsStockCollection
    {
        List<clsStock> stockList;
        Int32 count;
        clsStock thisStock;


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

        public clsStockCollection()
        {
        }

        public clsStockCollection(List<clsStock> stockList, int count, clsStock thisStock)
        {
            this.stockList = stockList;
            this.count = count;
            this.thisStock = thisStock;
        }

        public List<clsStock> StockList { get => stockList; set => stockList = value; }
        public int Count { get => count; set => count = value; }
        public clsStock ThisStock { get => thisStock; set => thisStock = value; }

    }
}
