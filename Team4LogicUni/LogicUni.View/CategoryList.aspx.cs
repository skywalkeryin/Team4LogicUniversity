using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicUni.Controller;
using LogicUni.DataModel.Models;

namespace LogicUni.View
{
    public partial class CategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        public void BindDataGridView()
        {
            CategoryController controller = new CategoryController();
            dgvCategoryList.AutoGenerateColumns = true;
            dgvCategoryList.DataSource = null;
            IList<Category> list = controller.GetAllCategories();
            dgvCategoryList.DataSource = list;
            dgvCategoryList.DataBind();
        }
    }
}