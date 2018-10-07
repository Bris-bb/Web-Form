using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;

namespace WingtipToys
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Product> GetProduct([QueryString] int? productID)
        {
            var _db = new WingtipToys.Models.ProductContext();
            IQueryable<Product> query;
            if (productID.HasValue || productID > 0)
                query = _db.Products.Where(p => p.ProductID == productID);
            else query = null;
            return query;
        }
    }
}