IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[product_type]')) 
   ALTER TABLE [dbo].[product_type] 
   DISABLE  CHANGE_TRACKING
GO
