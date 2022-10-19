IF NOT EXISTS(SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO [User] (Id, UserName, [Password], FirstName, LastName, [Type], IsDeleted, CreatedDate)
	VALUES 
		(NEWID(), 'tu.nguyen', '123', 'Tu', 'Nguyen', 0, 0, GETDATE()),
		(NEWID(), 'than.tran', '123', 'Than', 'Tran', 0, 0, GETDATE())
END