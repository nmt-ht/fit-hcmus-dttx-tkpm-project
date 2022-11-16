/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 16, 2022
	Description		:	Book Management - Insert data for Order Item table
*/
CREATE PROCEDURE [dbo].[spr_Receipt_Update]
(
	@Id UNIQUEIDENTIFIER,
	@Order_ID_FK UNIQUEIDENTIFIER,
	@Status TINYINT
)
AS
BEGIN
	UPDATE R
	SET R.[Status] = @Status
	FROM Receipt R
	WHERE r.Id = @Id AND r.Order_ID_FK = @Order_ID_FK

	UPDATE cus
	SET cus.Debt = cus.Debt - r.TotalCustCost
	FROM Customer cus
	JOIN [Order] o ON o.Id = cus.Order_ID_FK
	JOIN Receipt r ON r.Order_ID_FK = o.Id
	WHERE r.Id = @Id AND o.Id = @Order_ID_FK
END