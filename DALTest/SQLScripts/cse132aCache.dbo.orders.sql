IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[orders]')) 
   ALTER TABLE [dbo].[orders] 
   ENABLE  CHANGE_TRACKING
GO
