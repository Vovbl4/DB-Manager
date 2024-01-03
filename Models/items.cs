using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyrofest_Manager_App.Models
{
    internal class Item
    {
        [Key]
        public int Id { get; set; }
        public string Vendor_Code { get; set; }
        public string Text_ro {  get; set; }
        public string Text_ru { get; set; }
        public float Price_mdl { get; set; }
        public int Discount { get; set; }
        public string Image_path { get; set; }
        public int Caliber {  get; set; }
        public bool In_Stock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public Item(string vendor_Code, string text_ro, string text_ru, float price_mdl, int discount, string image_path, int caliber, bool in_Stock, int categoryID)
        {
            Vendor_Code = vendor_Code;
            Text_ro = text_ro;
            Text_ru = text_ru;
            Price_mdl = price_mdl;
            Discount = discount;
            Image_path = image_path;
            Caliber = caliber;
            In_Stock = in_Stock;
            CategoryID = categoryID;
        }
    }
}
