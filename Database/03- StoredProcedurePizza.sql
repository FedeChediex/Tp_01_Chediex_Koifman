CREATE PROCEDURE GetPizzaById
    @Id INT
AS
BEGIN
    SELECT * FROM Pizzas WHERE Id = @Id
END

CREATE PROCEDURE GetPizzas
AS
BEGIN
    SELECT * FROM Pizzas
END

CREATE PROCEDURE CreatePizza
    @nombre varchar(50),
    @descripcion varchar(255),
    @libreGluten bit,
    @importe decimal(18,2)
AS
BEGIN
    INSERT INTO Pizzas(Nombre, Descripcion, LibreGluten, Importe)
    VALUES(@nombre, @descripcion, @libreGluten, @importe)
END

CREATE PROCEDURE UpdatePizza
    @Id int,
    @nombre varchar(50),
    @descripcion varchar(255),
    @libreGluten bit,
    @importe decimal(18,2)
AS
BEGIN
    UPDATE Pizzas 
    SET Nombre = @nombre, Descripcion = @descripcion, LibreGluten = @libreGluten, Importe = @importe
    WHERE Id = @Id
END


CREATE PROCEDURE DeletePizza
    @id int
AS
BEGIN
    DELETE FROM Pizzas
    WHERE Id = @id
END

