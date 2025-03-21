/****** Object:  UserDefinedFunction [dbo].[GetDistancesFromMajorAustralianAiports]    Script Date: 05/30/2012 18:11:48 ******/

CREATE FUNCTION [dbo].[GetDistancesFromMajorAustralianAiports]
(
	@DestinationAirport nvarchar(255)
)
RETURNS @returntable TABLE
(
	[Id] int not null,
	[StartPoint] NVarchar(255),
	[EndPoint]  NVarchar(255),
	[StartPointAirportCode] NVarChar(10),
	[Distance] int
)
AS
BEGIN
declare @destinationName nvarchar(255)
declare @destinationLocation Geography
select @destinationName = AirportName,
	@destinationLocation = Location 
	from Airports
	where AirportCode = @DestinationAirport

	INSERT @returntable
	SELECT Id, 
		   AirportName, 
		   @destinationName,
		   AirportCode,
		   (Location.STDistance(@destinationLocation)/1000) 
    FROM Airports
	WHERE Country = 'Australia'
		  and AirportName like '% intl'
	RETURN
END
GO
