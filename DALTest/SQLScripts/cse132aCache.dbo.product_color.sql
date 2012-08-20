IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[product_color]')) 
   ALTER TABLE [dbo].[product_color] 
   ENABLE  CHANGE_TRACKING
GO
