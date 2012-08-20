﻿using System;
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

        public static int UpdateProduct(int product_id, string product_name, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "update_product";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_name", SqlDbType.VarChar, 255));

                mySA.SelectCommand.Parameters["@product_id"].Value = product_id;
                mySA.SelectCommand.Parameters["@product_name"].Value = product_name;

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

        public static int UpdateBrand(int brand_id, string brand_name, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "update_brand";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@brand_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@brand_name", SqlDbType.VarChar, 60));

                mySA.SelectCommand.Parameters["@brand_id"].Value = brand_id;
                mySA.SelectCommand.Parameters["@brand_name"].Value = brand_name;

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

        public static int UpdateProductCutting(int product_cutting_id, string product_cutting_name, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "update_product_cutting";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_cutting_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_cutting_name", SqlDbType.VarChar, 50));

                mySA.SelectCommand.Parameters["@product_cutting_id"].Value = product_cutting_id;
                mySA.SelectCommand.Parameters["@product_cutting_name"].Value = product_cutting_name;

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

        public static int UpdateProductColor(int product_color_id, string product_color_name, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "update_product_color";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_color_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_color_name", SqlDbType.VarChar, 50));

                mySA.SelectCommand.Parameters["@product_color_id"].Value = product_color_id;
                mySA.SelectCommand.Parameters["@product_color_name"].Value = product_color_name;

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

        public static int UpdateProductType(int product_type_id, string product_type_name, ref List<string> errors)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                string strSQL = "update_product_type";

                SqlDataAdapter mySA = new SqlDataAdapter(strSQL, conn);
                mySA.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_type_id", SqlDbType.Int));
                mySA.SelectCommand.Parameters.Add(new SqlParameter("@product_type_name", SqlDbType.VarChar, 30));

                mySA.SelectCommand.Parameters["@product_type_id"].Value = product_type_id;
                mySA.SelectCommand.Parameters["@product_type_name"].Value = product_type_name;

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