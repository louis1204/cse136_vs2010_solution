IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[product]')) 
   ALTER TABLE [dbo].[product] 
   DISABLE  CHANGE_TRACKING
GO
