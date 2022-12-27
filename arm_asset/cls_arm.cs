using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arm_asset
{
    class cls_arm
    {
        static string  sql = "";
        public static void Add소속부대(ComboBox cmb소속부대)
        {
            string w = "";

            cmb소속부대.Items.Clear();
            cmb소속부대.Items.Add("");
            sql = "select * from a101_arm order " + w + "  by arm_code";

            DataSet ds = cls_com.Select_Query(sql);
            cmb소속부대.Items.Clear();
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmb소속부대.Items.Add("");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb소속부대.Items.Add(ds.Tables[0].Rows[i]["arm_code"].ToString() + " " + ds.Tables[0].Rows[i]["arm"].ToString());
                }
            }
        }

        public static void Add소속부대(ComboBox cmb소속부대, string id)
        {
            string w = "";
            string 등급 = "";
            sql = "select * from a101_user  where id = '" + id + "' ";
            cmb소속부대.Items.Clear();
            cmb소속부대.Items.Add("");

            DataSet ds0 = cls_com.Select_Query(sql);
            if (ds0.Tables[0].Rows.Count <= 0)
            {
                return;
            }
            등급 = ds0.Tables[0].Rows[0]["degree"].ToString(); 

            if (!등급.Equals("총관리자"))
            {
                w = "where arm_code in (select arm_code from a101_user_arm where id = '" + id + "' ) ";
            }

               
            sql = "select * from a101_arm  " +  w + " order  by arm_code";

            DataSet ds = cls_com.Select_Query(sql);
            cmb소속부대.Items.Clear();
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmb소속부대.Items.Add("");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb소속부대.Items.Add(ds.Tables[0].Rows[i]["arm_code"].ToString() + " " + ds.Tables[0].Rows[i]["arm"].ToString());
                }
            }
        }

    }
}

