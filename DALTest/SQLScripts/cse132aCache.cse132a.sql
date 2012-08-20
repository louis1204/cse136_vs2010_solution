IF NOT EXISTS (SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID(N'cse132a')) 
   ALTER DATABASE [cse132a] 
   SET  CHANGE_TRACKING = ON
GO
