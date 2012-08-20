IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[brand]')) 
   ALTER TABLE [dbo].[brand] 
   DISABLE  CHANGE_TRACKING
GO
