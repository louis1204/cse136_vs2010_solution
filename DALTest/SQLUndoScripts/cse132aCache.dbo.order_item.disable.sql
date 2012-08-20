IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[order_item]')) 
   ALTER TABLE [dbo].[order_item] 
   DISABLE  CHANGE_TRACKING
GO
