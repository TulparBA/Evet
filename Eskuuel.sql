Create Table Accounts(
AccountID char(10) Primary key not null,
FirstName varchar(50),
LastName varchar(50),
Branch Int,
Balance Money
);

INSERT INTO Accounts
VALUES('0000065127','Cihan','Özhan',489,10000),
('0000065128','Burak','Arzuman',490,36482594),
('0000065129','Ecem','Yanar',490,5183952),
('0000065130','Alperen','Tanrıkut',490,15472984),
('0000065131','Tolga','Köklü',489,2543485);



Create Proc sp_MoneyTranfer(
@PurchaserID Char(10),
@SenderID Char(10),
@Amount Money,
@retVal Int out
)
As
Begin
	Declare @inControl Money;
	Select @inControl = Balance From Accounts Where AccountID=@SenderID;
	If @inControl>=@Amount
	Begin
		Begin Transaction
			Update Accounts
			Set Balance=Balance-@Amount
			Where AccountID=@SenderID
		If @@ERROR <> 0
		Rollback
		Update Accounts
		set Balance=Balance+@Amount
		Where AccountID=@PurchaserID
		If @@ERROR <> 0
		Rollback
		Commit
	End
	Else
	Begin
		Set @retVal=-1;
		return @retVal;
	end
end;

declare @rVal int;
exec sp_MoneyTranfer '0000065128','0000065128',20472984,@rVal out;
select @rVal;

select * from Accounts
