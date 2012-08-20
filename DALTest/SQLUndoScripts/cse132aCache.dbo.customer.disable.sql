IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[customer]')) 
   ALTER TABLE [dbo].[customer] 
   DISABLE  CHANGE_TRACKING
GO
