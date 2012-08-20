IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[product_cutting]')) 
   ALTER TABLE [dbo].[product_cutting] 
   DISABLE  CHANGE_TRACKING
GO
