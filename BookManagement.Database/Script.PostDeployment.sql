IF NOT EXISTS(SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO [User] (Id, UserName, [Password], FirstName, LastName, [Type], IsDeleted, CreatedDate)
	VALUES 
		(NEWID(), 'tu.nguyen', '123', 'Tu', 'Nguyen', 0, 0, GETDATE()),
		(NEWID(), 'than.tran', '123', 'Than', 'Tran', 0, 0, GETDATE())
END
GO
IF NOT EXISTS(SELECT 1 FROM dbo.Book)
BEGIN

	-- Reference: https://sachhay24h.com/list-10-tac-pham-van-hoc-kinh-dien-noi-tieng-the-gioi-a638.html
	DECLARE @UserID UNIQUEIDENTIFIER = NULL
	SELECT @UserID = u.Id
	FROM [User] u
	WHERE u.UserName = 'tu.nguyen'

	INSERT INTO [Book] (Id, [Name], [Author], [Description], Quantity, TypeOfBook, Price, IsDeleted, CreatedDate, CreatedBy)
	VALUES
	(NEWID(), N'Những người khốn khổ', 'Victor Hugo', N'“Những người khốn khổ” được xuất bản năm 1962 là tác phẩm văn học nổi tiếng của đại văn hào Victor Hugo. “Những người khốn khổ” là câu chuyện về xã hội nước Pháp trong khoảng hơn 20 năm đầu thế kỉ 19 kể từ thời điểm Napoléon I lên ngôi và vài thập niên sau đó. Một tác phẩm rất ý nghĩa và mang lại nhiều giá trị thực tiễn. Xét về hiện thực, tác phẩm của Victor Hugo đã miêu tả một cách chân thực thế giới của những con người nghèo khổ. Tác phẩm khiến cho người đọc có cái nhìn về cuộc sống, biết yêu thương, chia sẻ và trân trọng những gì mình đáng có',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Bắt trẻ đồng xanh', 'J.D Salinger', N'“Xuất bản năm 1951, “Bắt trẻ đồng xanh” của J.D Salinger đã gây tiếng vang lớn vì một thời gian cuốn sách bị kiểm duyệt. Sự nổi loạn của tuổi trẻ, những khao khát thầm kín và cảm giác bị mất phương hướng trong cuộc sống ở tuổi thiếu niên là những gì được viết trong tác phẩm. Hơn thế nữa đó là cái nhìn trong trẻo vừa hồn nhiên vừa chân thực trước những thói đạo đức giả trong xã hội. Tác giả đã thể hiện sự thông minh và khéo léo trong cách kể chuyện của mình. Không quá cầu kì, chỉ với ngôn từ hết sức đơn giản nhưng lại đi sâu vào trong tiềm thức của con người.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Cuốn theo chiều gió', 'Margaret Mitchell', N'Tác phẩm “Cuốn theo chiều gió” là một tiểu thuyết nổi tiếng của nhà văn Margaret Mitchell, được xuất bản năm 1936. Xuyên suốt tác phẩm là hình ảnh cô gái Scarlett O’Hara ở miền Nam vừa xinh đẹp, thông minh vừa mạnh mẽ với lối sống phóng khoáng, dám nghĩ dám làm. Hình ảnh của cô tượng trưng cho những người phụ nữ hiện đại, mạnh mẽ, tự lập, khao khát khẳng định chính mình. Tác phẩm còn ca ngợi tình yêu đối lứa qua chuyện tình lãng mạn của Scarlett O’Hara và chàng Rhett Butler. Qua tác phẩm người đọc sẽ có bài học về lí tưởng sống, tình yêu thương, sức mạnh vượt qua khổ đau, bất hạnh và tình yêu nam nữ.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Ông già và biển cả', 'Emest Hemingway', N'“Ông già và biển cả” được coi là một trong những tác phẩm nổi bật nhất trong sự nghiệp của nhà văn Emest Hemingway viết vào năm 1952. Đến với tác phẩm này, người đọc như được đồng hành với hành trình đánh bắt cá kiểm khổng lồ vô cùng khó khăn của ông lão đánh cá Santiago trong ba ngày. Tưởng chừng vận may đã mỉm cười với ông khi ông có thể thu phục được con cá kiếm đẹp nhất thế giới, nào ngờ lũ cá mập lại lao tới rỉa sạch con cá kiếm. Khi kết thúc hành trình, thật buồn khi thành quả ông nhận được chỉ là bộ xương vô dụng. Dù nội dung đơn giản nhưng ẩn chứa những tầng nghĩa sâu sắc, những thông điệp ý nghĩa mà tác giả muốn gửi gắm tới độc giả.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Đồi gió hú', 'Emily Bronte', N'Cuốn tiểu thuyết duy nhất của Emily Bronte là “Đồi gió hú” đã tới tay công chúng vào năm 1847. Cuốn tiểu thuyết bí ẩn và dữ dội về cô gái Catherine Earnshaw nổi loạn của gia đình Earnshaw với gã đàn ông Heathcliff thô ráp và điên rồ được cha cô mang về nhà. Toàn bộ thời gian hai con người yêu nhau đó sống trong thù hận và tuyệt vọng bởi bản tính ghen tuông tột độ và cả gia đình, địa vị xã hội và số phận cũng rắp tâm chống lại họ. Thông qua mối tình giữa Cathy và Heathcliff, “Đồi gió hú” đã trở thành một trong những tiểu thuyết vĩ đại, bi thương nhất mà con người từng viết ra về nỗi đam mê cháy bỏng.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Chiến tranh và hòa bình', 'Nikolayevich', N'“Chiến tranh và hòa bình” là bộ tiểu thuyết sử thi phản ánh một giai đoạn bi tráng của toàn xã hội Nga, từ giới quý tộc đến nông dân, trong thời đại Napoléon của tác giả Nikolayevich Tolstoy in lần đầu từ năm 1865 đến 1869. Tác phẩm sáng ngời khát vọng yêu chuộng hòa bình, làm bừng lên một chủ nghĩa nhân văn sâu sắc. Nghệ thuật miêu tả tâm lí nhân vật là một trong những điểm nổi bật của tác phẩm. Số phận nhân vật và những tâm trạng tinh tế đều gắn liền với từng bước thăng trầm lịch sử. Tác phẩm được đánh giá xứng đáng là một trong những tiểu thuyết vĩ đại nhất của văn học thế giới.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Tiếng chim hót trong bụi mận gai', 'Colleen McCulough', N'Nữ nhà văn Úc Colleen McCulough đã cho ra đời tác phẩm “Tiếng chim hót trong bụi mận gai” là một tuyệt phẩm có sức lan tỏa mạnh mẽ. Tác phẩm là câu chuyện tình yêu của Mecghi xinh đẹp và Cha xứ Ranfơ. Nhưng vì thân phận, địa vị của mình nên cha xứ đã phải chạy trốn cảm xúc suốt đời. Tình yêu của họ là cảm xúc yêu thương mãnh liệt, những chia xa, những gần nhau rồi lại là đau khổ, bi kịch. Kết thúc câu chuyện là kết thúc của một tình yêu, đã lấy đi bao nhiêu nước mắt của người đọc. Hãy đến với “Tiếng chim hót trong bụi mận gai”, bạn sẽ được hòa mình vào trong nỗi niềm của từng nhân vật, một tác phẩm có sức lay động mãnh liện lòng người.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Ba gã cùng thuyền', 'Jerome K.Jerome', N'Xuất bản tại Anh quốc vào năm 1889, “Ba gã cùng thuyền” của nhà văn Jerome K. Jerome là tác phẩm hài hước dựa trên những sự kiện có thật của tác giả trong hành trình bằng thuyền trên sông Thames từ Kingston tới Oxford. Những mẩu chuyện xuất phát từ những tình huống xảy ra trong chuyến du ngoạn, những cũng có khi là những câu chuyện được kể lại đan cài với diễn biến thực tế vô hại khiến độc giả sảng khoái theo dõi và bật cười. Tác phẩm cùng giọng văn đặc trưng của Jerome K. Jerome đã chinh phục nhiều độc giả ưa thích những câu chuyện dí dỏm, duyên dảng và hóm hỉnh trong tác phẩm. Nếu bạn đang tìm một tác phẩm văn học hài hước để đọc thì đừng bỏ qua tác phẩm này.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Tuổi thơ dữ dội', 'Phùng Quán', N'“Tuổi thơ dữ dội” của tác giả Phùng Quán xoay quanh cuộc sống chiến đấu và hy sinh của những thiếu niên Lượm, Mừng, Quỳnh cơn ca, Hòa đen, Bồng da rắn,… Dù mới 13,14 tuổi và mỗi người một hoàn cảnh khác nhau nhưng đều chung lòng quyết tâm, nhiệt huyết và lòng yêu nước, tham gia chiến đấu hết mình và hy sinh khi tuổi đời còn rất trẻ. Độc giả sẽ bắt gặp ở đó những chi tiết thực sự dữ dội về cuộc đời thiếu niên bất hạnh, về cuộc chiến tranh chống giặc tàn khốc nhưng sâu bên trong ta vẫn thấy được những tâm hồn trong sáng và vô tư, sự dũng cảm phi thường của nhân vật đúng như tên của tác phẩm “Tuổi trẻ dữ dội”.',
		10, 1, 100, 0, GETDATE(), @UserID),
	(NEWID(), N'Trăm năm cô đơn', 'Gabriel Garcia Marquez', N'Năm 1967, tác phẩm “Trăm năm cô đơn” của Gabriel Garcia Marquez ra đời đã gây dư luận sôi nổi và được cả thế giới hâm mộ. Là câu chuyện về dòng họ Buênđya tồn tại bảy thế hệ - một dòng họ tự lưu đày vào cõi cô đơn để trốn tội loạn luân, người đầu tiên bị trói vào gốc cây và người cuối cùng bị kiến ăn.',
		10, 1, 100, 0, GETDATE(), @UserID)
END
IF NOT EXISTS(SELECT 1 FROM dbo.Parameter)
BEGIN
	INSERT INTO [Parameter] (Id, [Name], [IsActive], ParameterType, [Value])
	VALUES
	(NEWID(), N'Số Lượng Sách Nhập Ít Nhất', 1, 1, 150),
	(NEWID(), N'Đầu Sách Có Lượng Tồn Ít Hơn', 1, 1, 300),
	(NEWID(), N'Khách Hàng Nợ Không Quá ', 1, 1, 20000),
	(NEWID(), N'Đầu Sách Có Số Lượng Tồn Sau Khi Bán Ít Nhất ', 1, 1, 20)
END
IF NOT EXISTS(SELECT 1 FROM dbo.Customer)
BEGIN
	DECLARE @CustomerID UNIQUEIDENTIFIER = NEWID()
	DECLARE @UserID UNIQUEIDENTIFIER = NULL
	SELECT @UserID = u.Id
	FROM [User] u
	WHERE u.UserName = 'tu.nguyen'

	INSERT INTO Customer (Id, FirstName, LastName, Gender, Birthday, IsActive, CreatedBy, CreatedDate)
	VALUES(@CustomerID, 'Tu', 'Nguyen', 1, '10/12/1999', 1, @UserID, GETDATE())

	INSERT INTO CustomerAddress (Id, Phone, Email, Address, City, Country, Type, Customer_ID_FK)
	VALUES(NEWID(), '0974566324', 'test@gmail.com', 'Quan 9',  'TP Thu Duc', 'Viet Nam', 0, @CustomerID)

	INSERT INTO CustomerAddress (Id, Phone, Email, Address, City, Country, Type, Customer_ID_FK)
	VALUES(NEWID(), '0974566324', 'test@gmail.com', 'Quan 1',  'TP Ho Chi Minh', 'Viet Nam', 1, @CustomerID)

	SET @CustomerID = NEWID()
	
	INSERT INTO Customer (Id, FirstName, LastName, Gender, Birthday, IsActive, CreatedBy, CreatedDate)
	VALUES(@CustomerID, 'Than', 'Tran', 2, '1/1/1999', 1, @UserID, GETDATE())

	INSERT INTO CustomerAddress (Id, Phone, Email, Address, City, Country, Customer_ID_FK)
	VALUES(NEWID(), '0974566111', 'test2@gmail.com', 'Quan 9',  'TP Thu Duc', 'Viet Nam', @CustomerID)
END
IF(NOT EXISTS(SELECT 1 FROM Inventory))
BEGIN
	DECLARE @UserID UNIQUEIDENTIFIER = (SELECT ID FROM [User] WHERE UserName = 'tu.Nguyen')

	INSERT INTO Inventory(Id, AvailableQty, Book_ID_FK, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, IsDeleted)
	SELECT NEWID(),  b.Quantity, b.Id, @UserID, GETDATE(), NULL, NULL, 0
	FROM Book b
END