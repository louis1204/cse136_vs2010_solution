using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DomainModel;  // must add this...
using System.Configuration; // must add this... make sure to add "System.Configuration" first
using System.Data.SqlClient; // must add this...
using System.Data; // must add this...

namespace DAL
{
    public static class DALProductVariationInfo
    {
        static string connection_string = ConfigurationManager.AppSettings["dsn"];

        public static int CreatePV(ProductVariationInfo ProductVariationInfo, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "create_pv";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_brand_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_cutting_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_color_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_type_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@sex", SqlDbType.Char));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@size", SqlDbType.Char));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@stock", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Float));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@condition", SqlDbType.Char));

                SqlParameter pvIdParmOut = new SqlParameter("@product_variation_id_output", SqlDbType.Int);
                pvIdParmOut.Direction = ParameterDirection.Output;
                mySA.SelectCommand.Parameters.Add(pvIdParmOut);

                mySA.SelectCommand.Parameters["@product_id"].Value = ProductVariationInfo.product_id;
                mySA.SelectCommand.Parameters["@product_brand_id"].Value = ProductVariationInfo.product_brand_id;
                mySA.SelectCommand.Parameters["@product_cutting_id"].Value = ProductVariationInfo.product_cutting_id;
                mySA.SelectCommand.Parameters["@product_color_id"].Value = ProductVariationInfo.product_color_id;
                mySA.SelectCommand.Parameters["@product_type_id"].Value = ProductVariationInfo.product_type_id;
                mySA.SelectCommand.Parameters["@sex"].Value = ProductVariationInfo.sex;
                mySA.SelectCommand.Parameters["@size"].Value = ProductVariationInfo.size;
                mySA.SelectCommand.Parameters["@stock"].Value = ProductVariationInfo.stock;
                mySA.SelectCommand.Parameters["@price"].Value = ProductVariationInfo.price;
                mySA.SelectCommand.Parameters["@condition"].Value = ProductVariationInfo.condition;

                DataSet myDS = new DataSet();
                mySA.Fill(myDS);
                return 1;
            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("THIS IS THE ERROR: " + e.ToString());
                errors.Add("Error: " + e.ToString());
                return -1;
            }
            finally
            {
                conn.Dispose();
                conn = null;
            }
        }

        public static ProductVariationInfo ReadPVDetail(int product_variation_id, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            ProductVariationInfo pv = null;

            try
            {
                string strSQL = "read_pv";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_variation_id", SqlDbType.Int));

                mySA.SelectCommand.Parameters["@product_variation_id"].Value = product_variation_id;

                DataSet myDS = new DataSet();
                mySA.Fill(myDS);

                if (myDS.Tables[0].Rows.Count == 0)
                    return null;

                pv = new ProductVariationInfo((int)myDS.Tables[0].Rows[0]["product_variation_id"],
                    (int)myDS.Tables[0].Rows[0]["product_id"],
                    (int)myDS.Tables[0].Rows[0]["product_brand_id"],
                    (int)myDS.Tables[0].Rows[0]["product_cutting_id"],
                    (int)myDS.Tables[0].Rows[0]["product_color_id"],
                    (int)myDS.Tables[0].Rows[0]["product_type_id"],
                    (char)myDS.Tables[0].Rows[0]["sex"],
                    myDS.Tables[0].Rows[0]["size"].ToString(),
                    (int)myDS.Tables[0].Rows[0]["stock"],
                    (float)myDS.Tables[0].Rows[0]["price"],
                    (char)myDS.Tables[0].Rows[0]["condition"]);
            }
            catch (Exception e)
            {
                errors.Add("Error: " + e.ToString());
            }
            finally
            {
                conn.Dispose();
                conn = null;
            }

            return pv;
        }

        public static List<ProductVariationInfo> ReadPVList(ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            ProductVariationInfo pv = null;
            List<ProductVariationInfo> pvList = new List<ProductVariationInfo>();

            try
            {
                string strSQL = "read_all_pv";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet myDS = new DataSet();
                mySA.Fill(myDS);

                if (myDS.Tables[0].Rows.Count == 0)
                    return null;

                for (int i = 0; i < myDS.Tables[0].Rows.Count; i++)
                {
                    pv = new ProductVariationInfo((int)myDS.Tables[0].Rows[i]["product_variation_id"],
                        (int)myDS.Tables[0].Rows[i]["product_id"],
                        (int)myDS.Tables[0].Rows[i]["product_brand_id"],
                        (int)myDS.Tables[0].Rows[i]["product_cutting_id"],
                        (int)myDS.Tables[0].Rows[i]["product_color_id"],
                        (int)myDS.Tables[0].Rows[i]["product_type_id"],
                        (char)myDS.Tables[0].Rows[i]["sex"],
                        myDS.Tables[0].Rows[i]["size"].ToString(),
                        (int)myDS.Tables[0].Rows[i]["stock"],
                        (float)myDS.Tables[0].Rows[i]["price"],
                        (char)myDS.Tables[0].Rows[i]["condition"]);
                    pvList.Add(pv);
                }
            }
            catch (Exception e)
            {
                errors.Add("Error: " + e.ToString());
            }
            finally
            {
                conn.Dispose();
                conn = null;
            }

            return pvList;
        }

        public static int UpdateProductVariationInfo(ProductVariationInfo ProductVariationInfo, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "update_pv";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_variation_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_brand_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_cutting_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_color_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_type_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@sex", SqlDbType.Char));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@size", SqlDbType.Char));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@stock", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Float));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@condition", SqlDbType.Char));

                mySA.SelectCommand.Parameters["@product_variation_id"].Value = ProductVariationInfo.product_variation_id;
                mySA.SelectCommand.Parameters["@product_id"].Value = ProductVariationInfo.product_id;
                mySA.SelectCommand.Parameters["@product_brand_id"].Value = ProductVariationInfo.product_brand_id;
                mySA.SelectCommand.Parameters["@product_cutting_id"].Value = ProductVariationInfo.product_cutting_id;
                mySA.SelectCommand.Parameters["@product_color_id"].Value = ProductVariationInfo.product_color_id;
                mySA.SelectCommand.Parameters["@product_type_id"].Value = ProductVariationInfo.product_type_id;
                mySA.SelectCommand.Parameters["@sex"].Value = ProductVariationInfo.sex;
                mySA.SelectCommand.Parameters["@size"].Value = ProductVariationInfo.size;
                mySA.SelectCommand.Parameters["@stock"].Value = ProductVariationInfo.stock;
                mySA.SelectCommand.Parameters["@price"].Value = ProductVariationInfo.price;
                mySA.SelectCommand.Parameters["@condition"].Value = ProductVariationInfo.condition;

                DataSet myDS = new DataSet();
                mySA.Fill(myDS);
                return 1;
            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("THIS IS THE ERROR: " + e.ToString());
                errors.Add("Error: " + e.ToString());
                return -1;
            }
            finally
            {
                conn.Dispose();
                conn = null;
            }
        }

        public static int DeleteProductVariationInfo(int product_variation_id, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "delete_pv";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_variation_id", SqlDbType.Int));

                mySA.SelectCommand.Parameters["@product_variation_id"].Value = product_variation_id;

                DataSet myDS = new DataSet();
                mySA.Fill(myDS);
                return 1;
            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("THIS IS THE ERROR: " + e.ToString());
                errors.Add("Error: " + e.ToString());
                return -1;
            }
            finally
            {
                conn.Dispose();
                conn = null;
            }
        }
    }
}
