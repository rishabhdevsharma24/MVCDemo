using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DemoRepository.DataAccess
{
 public   class Implemantation : InterfaceRepo
    {

        public static string conn = ConfigurationManager.ConnectionStrings["DCBS"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        public void Dlt_Record(XpayDetails xp)
        {
            SqlCommand com = new SqlCommand("XpayDeleteData", con);
            com.CommandType = CommandType.StoredProcedure;
         com.Parameters.AddWithValue("@Id", xp.Id);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Insert_record(XpayDetails xp)
        {
            try
            {
                SqlCommand com = new SqlCommand("XpayInsertData", con);
                com.CommandType = CommandType.StoredProcedure;
               //  com.Parameters.AddWithValue("@Id", xp.Id);
                com.Parameters.AddWithValue("@Name", xp.Name);
                com.Parameters.AddWithValue("@Amount", xp.Amount);
                com.Parameters.AddWithValue("@Description ", xp.Description);
                
                com.Parameters.AddWithValue("@TermAndCondition", xp.TermAndCondition);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Data  inserted");
                con.Close();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

        }

        public List<XpayDetails> Show_Record()
        {
            List<XpayDetails> lst = new List<XpayDetails>();

            SqlCommand com = new SqlCommand("XpayDisplayData", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                lst.Add
                             (
                             new XpayDetails
                             {
                                 Id = Convert.ToInt64(dr["Id"]),
                                 Name = Convert.ToString(dr["Name"]),
                                 Description = Convert.ToString(dr["Description"]),
                                 Amount = Convert.ToDecimal(dr["Amount"]),
                                 TermAndCondition = Convert.ToString(dr["TermAndCondition"])
                             }


                     );

            }
            return lst;
        }

        public void Update_Record(XpayDetails xp)
        {
            try
            {
                SqlCommand com = new SqlCommand("XpayUpdateData", con);
                com.CommandType = CommandType.StoredProcedure;
                 com.Parameters.AddWithValue("@Id", xp.Id);
                com.Parameters.AddWithValue("@Name", xp.Name);
                com.Parameters.AddWithValue("@Amount", xp.Amount);
                com.Parameters.AddWithValue("@Description ", xp.Description);

                com.Parameters.AddWithValue("@TermAndCondition", xp.TermAndCondition);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Data Updated");
                con.Close();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
    }
}