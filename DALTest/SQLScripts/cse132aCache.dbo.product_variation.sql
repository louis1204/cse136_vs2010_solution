IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[product_variation]')) 
   ALTER TABLE [dbo].[product_variation] 
   ENABLE  CHANGE_TRACKING
GO
