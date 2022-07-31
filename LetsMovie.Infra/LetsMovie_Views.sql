/*==========================

VIEW

===========================*/

CREATE VIEW VwMoviesInfo

AS

SELECT CONCAT('O filme "', a.Title,'" lançado em ', 
YEAR(a.DateOfRelease),' é estrelado por ', c.Name, ' como ', Role) as MovieInfo
FROM Movie a
INNER JOIN Act b
ON a.ID_Movie = b.ID_Movie
INNER JOIN PrincipalActor c
ON b.ID_Actor = c.ID_Actor

END