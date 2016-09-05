using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUni.DataModel.Models
{
    public class Category
    {
        private int categoryId;
        private string categoryName;
        private int bin;
        private int checkPointId;
        private string checkPointName;

        public Category() { }

        public Category(int categoryId, string categoryName, int bin, int checkPointId)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            this.bin = bin;
            this.checkPointId = checkPointId;
        }

        public Category(int categoryId, string categoryName, int bin, int checkPointId, string checkPointName)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            this.bin = bin;
            this.checkPointId = checkPointId;
            this.checkPointName = checkPointName;
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public int Bin
        {
            get { return bin; }
            set { bin = value; }
        }

        public int CheckPointId
        {
            get { return checkPointId; }
            set { checkPointId = value; }
        }

        public string CheckPointName
        {
            get { return checkPointName; }
            set { checkPointName = value; }
        }
    }
}
