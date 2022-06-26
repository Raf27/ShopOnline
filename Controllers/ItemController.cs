using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopOnline.Models;
using System.IO;
using ShopOnline.ViewModel;
using System.Data.SqlClient;

namespace ShopOnline.Controllers
{
    public class ItemController : Controller
    {
        private ShopOnlineDBEntities objShopOnlineDBEntities;
        public ItemController()
        {
            objShopOnlineDBEntities = new ShopOnlineDBEntities();
        }
        // GET: Item

        public ActionResult Index1()
        {
            ItemViewModel objItemViewModel = new ItemViewModel();
            objItemViewModel.ListItemId = (from objItem in objShopOnlineDBEntities.Items
                                           select new SelectListItem()
                                           {
                                               Text = "<Item Text>",
                                               Value = objItem.ItemId.ToString(),
                                               Selected = true
                                           })
                               .ToList();
            return View(objItemViewModel);
        }


        public ActionResult Index()
        {
            ItemViewModel objItemViewModel = new ItemViewModel();
            objItemViewModel.CategorySelectListItem = (from objCat in objShopOnlineDBEntities.Categories
                                                       select new SelectListItem()
                                                       {
                                                           Text = objCat.CategoryName,
                                                           Value = objCat.CategoryId.ToString(),
                                                           Selected = true
                                                       });
            return View(objItemViewModel);
        }


        [HttpPost]
        public JsonResult Index(ItemViewModel objItemViewModel)
        {
            string NewImage = Guid.NewGuid() + Path.GetExtension(objItemViewModel.ImagePath.FileName);
            objItemViewModel.ImagePath.SaveAs(Server.MapPath("~/Images/" + NewImage));

            Item objItem = new Item();
            objItem.ImagePath = "~/Images/" + NewImage;
            objItem.CategoryId = objItemViewModel.CategoryId;
            objItem.Description = objItemViewModel.Description;
            objItem.ItemId = Guid.NewGuid();
            objItem.ItemName = objItemViewModel.ItemName;
            objItem.ItemPrice = objItemViewModel.ItemPrice;
            objShopOnlineDBEntities.Items.Add(objItem);
            objShopOnlineDBEntities.SaveChanges();

            return Json(new {Success = true, Message = "Item is added Successfully."}, JsonRequestBehavior.AllowGet);
        }

        private void btnUpdate(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-62V61RT\SQLEXPRESS; Initial Catalog =ShopOnlineDB; Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Item set CategoryId=@CategoryId, ItemName=@ItemName, Description=@Description, ItemPrice=@ItemPrice, ImagePath=@ImagePath where ItemID= @ItemId", con);
            cmd.Parameters.AddWithValue("@ItemId", int.Parse(txtbox1.Text));
            cmd.Parameters.AddWithValue("@CategoryId", int.Parse(txtbox2.Text));
            cmd.Parameters.AddWithValue("@ItemName", int.Parse(txtbox3.Text));
            cmd.Parameters.AddWithValue("@Description", int.Parse(txtbox4.Text));
            cmd.Parameters.AddWithValue("@ItemPrice", int.Parse(txtbox5.Text));
            cmd.Parameters.AddWithValue("@ImagePath", int.Parse(txtbox6.Text));

        }
    }
}