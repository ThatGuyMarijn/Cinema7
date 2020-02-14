SELECT *
FROM Films film
INNER JOIN FilmVertoningen filmVert
	on film.Id = filmVert.FilmId
INNER JOIN ReserveringenVertoningen resVert
	on filmVert.Id = resVert.VertoningsId
INNER JOIN Reserveringen res
	on resVert.ReserveringsId = res.ReserveringsId
INNER JOIN AspNetUsers users
	on res.KlantId = users.Id
WHERE res.KlantId like '%bfe1524b-2be9-4337-8832-96ddc56c2ea7%'
