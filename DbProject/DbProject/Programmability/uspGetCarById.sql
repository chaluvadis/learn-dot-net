CREATE PROCEDURE [dbo].[uspGetCarById]
  @Id int = 0
AS
SELECT *
from dbo.Cars
where Id = @Id
RETURN 0
