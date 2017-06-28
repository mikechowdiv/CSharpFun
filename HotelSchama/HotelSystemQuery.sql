USE HotelSystem
GO

/*1. List rooms by # of amenities, descending*/

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_NAME = 'RoomAmenitiesCountList')
DROP PROCEDURE RoomAmenitiesCountList
GO

CREATE PROCEDURE RoomAmenitiesCountList
AS
SELECT COUNT(Amenity.Name) AS AmenityCount, Room.RoomNumber
FROM Room
	LEFT JOIN RoomAmenity ON Room.RoomID = RoomAmenity.RoomID
	LEFT JOIN Amenity ON RoomAmenity.AmenityID = Amenity.AmenityID
GROUP BY Room.RoomNumber
ORDER BY AmenityCount DESC

GO

/* List rates for each room type for [July 1, 2017]*/

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_NAME = 'RoomRateByDate')
DROP PROCEDURE RoomRateByDate
GO

CREATE PROCEDURE RoomRateByDate(
	@RateDate Date
)
AS
SELECT * FROM RoomType JOIN RoomRate ON RoomType.RoomTypeID = RoomRate.RoomTypeID
WHERE StartDate <= @RateDate AND (EndDate >= @RateDate OR EndDate IS NULL)

GO

/*List all reservations that were booked with more than one guest*/

SELECT count(Guest.GuestID) as GuestCount, Reservation.ReservationID, StartDate, EndDate
FROM Reservation
	JOIN GuestReservation ON Reservation.ReservationID = GuestReservation.ReservationID
	JOIN Guest ON GuestReservation.GuestID = Guest.GuestID
GROUP BY Reservation.ReservationID, StartDate, EndDate
HAVING (COUNT(*) > 1)
ORDER BY Count(Guest.GuestID) DESC;

/*list billing info for the last reservation including room rates and add-ons */

