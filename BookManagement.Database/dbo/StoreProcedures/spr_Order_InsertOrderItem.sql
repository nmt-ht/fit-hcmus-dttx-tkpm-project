/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 13, 2022
	Description		:	Book Management - Insert data for Order Item table
*/
 CREATE PROCEDURE [dbo].[spr_Order_InsertOrderItem]
(
	@Price MONEY,
	@Quantity INT,
	@Book_ID_FK UNIQUEIDENTIFIER,
	@Order_ID_FK UNIQUEIDENTIFIER 
)
AS
BEGIN
	INSERT INTO OrderItem(Id, Book_ID_FK, Quantity, Price, Order_ID_FK)
	VALUES(NEWID(), @Book_ID_FK, @Quantity, @Price, @Order_ID_FK)
END