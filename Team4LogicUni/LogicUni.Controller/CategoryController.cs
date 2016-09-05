using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicUni.DataModel;


namespace LogicUni.Controller
{
    public class CategoryController
    {
        private Team4LogicEntities1 db;

        #region Constructor
        public CategoryController()
        {
            db = new Team4LogicEntities1();
        }
        #endregion

        #region Method
        public IList<LogicUni.DataModel.Models.Category> GetAllCategories()
        {
            try
            {
                var listCategory = (from c1 in db.Categories
                                    join c2 in db.CheckPoints on c1.CheckPointId equals c2.CheckPointId
                                    select new LogicUni.DataModel.Models.Category()
                                    {
                                        CategoryId = c1.CategoryId,
                                        CategoryName = c1.CategoryName,
                                        CheckPointId = c1.CheckPointId,
                                        CheckPointName = c2.CheckPointName
                                    }).ToList();
                return listCategory;
            }
            catch (Exception ex)
            {
                //Log Error
                string error = ex.Message.ToString();
                return null;
            }

        }
        #endregion
    }
}
