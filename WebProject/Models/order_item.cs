using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebPtoject.ExtraFunction;

namespace WebProject.Models
{
    public class order_item
    {
        public int order_id { get; set; }
        public int item_id { get; set; }
        public string count { get; set; }
        public string price { get; set; }
    }


    public class order_itemS
    {
        public static List<repository> SelectData(int? id)
        {
            SqlHandler sq = new SqlHandler();

            DbContext db = new DbContext(sq.ConnectionString());
            string query = "SELECT * FROM order_item WHERE Id = @id";

            return db.Database.SqlQuery<repository>(query, id).ToList<repository>();
        }


        public static int InsertData(string shop_category_id, string name, string description)
        {
            SqlHandler sq = new SqlHandler();

            DbContext db = new DbContext(sq.ConnectionString());
            string query = "INSERT INTO [dbo].[order_item] ([order_id] ,[item_id] ,[count],[price]) VALUES (@order_id ,@item_id, '@count' , '@price')";

            return db.Database.ExecuteSqlCommand(shop_category_id, name, description);
        }

        public static int UpdateData(string id, string shop_category_id, string name, string description)
        {
            SqlHandler sq = new SqlHandler();

            DbContext db = new DbContext(sq.ConnectionString());
            string query = "UPDATE [dbo].[order_item] SET [order_id]=@order_id ,[item_id]=@item_id ,[count]='@count',[price]='@price' where id=@id";

            return db.Database.ExecuteSqlCommand(query, id, shop_category_id, name, description);
        }


        public static int DeleteData(string id)
        {
            SqlHandler sq = new SqlHandler();

            DbContext db = new DbContext(sq.ConnectionString());
            string query = "DELETE FROM [dbo].[order_item] where id=@id";

            return db.Database.ExecuteSqlCommand(query, id);
        }
    }
}