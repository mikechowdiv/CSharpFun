CREATE TABLE tblProduct (
    ProductId int,
    Laptops varchar(30),
    UnitPrice decimal,
    Qty int 
);

INSERT INTO [dbo].[tblProduct] ([ProductId], [Laptops], [UnitPrice], [Qty]) VALUES (1, 'Apple', 2340, 32);
INSERT INTO [dbo].[tblProduct] ([ProductId], [Laptops], [UnitPrice], [Qty]) VALUES (2, 'Lenovo', 2440, 22);