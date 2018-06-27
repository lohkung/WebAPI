CREATE PROCEDURE [dbo].[SpGetCreditCard]
	@cardNumber nvarchar(16)
AS
	SELECT CardNumber 
	FROM CreditCard 
	WHERE CardNumber = @cardNumber  
GO
