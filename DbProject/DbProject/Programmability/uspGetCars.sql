CREATE PROCEDURE [dbo].[uspGetCars]
AS
SELECT Id, Make, Model, Color, [Year]
from dbo.Cars
RETURN 0
