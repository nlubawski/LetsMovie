




/*==========================

STORED PROCEDURE

===========================*/



-- Filmes

BEGIN


DROP TABLE IF EXISTS #FilmesMaisRecentes
SELECT TOP 5 *
INTO #FilmesMaisRecentes
FROM Movie
ORDER BY DateOfRelease DESC


DECLARE @IDMAX INT

SELECT @IDMAX = 
MAX(ID_ListMovie) + 1
FROM WatchListMovie


INSERT INTO WatchListMovie (ID_ListMovie, Name, ID_Movie)
SELECT @IDMAX as ID_ListMovie,'Filmes novos no LetsMovie' as Name, a.ID_Movie
FROM #FilmesMaisRecentes a
INNER JOIN Act b
ON a.ID_Movie = b.ID_Movie
INNER JOIN PrincipalActor c
ON b.ID_Actor = c.ID_Actor
ORDER BY a.DateOfRelease DESC


END

-- Serie

EXEC AtualizacaoSeriesMaratonar


CREATE PROCEDURE AtualizacaoSeriesMaratonar AS

BEGIN

DROP TABLE IF EXISTS #SeriesParaMaratonar
SELECT TOP 3 *
INTO #SeriesParaMaratonar
FROM Serie
ORDER BY Season DESC, NumberOfEpisode DESC


DECLARE @IDMAX INT

SELECT @IDMAX = 
MAX(ID_WatchListSerie) + 1
FROM WatchListSerie



INSERT INTO WatchListSerie (ID_ListSerie, Name, ID_Serie)
SELECT '1' as ID_WatchListSerie,'Série para maratonar' as Name, ID_Serie
FROM #SeriesParaMaratonar

END

-- Documentary

CREATE PROCEDURE DocumentarioParaConhecer AS

BEGIN

DECLARE @IDCOUNT INT, @RANDOM INT, @IDMAX INT

SELECT @IDMAX = MAX(ID_ListDocumentary) 
FROM WatchlistDocumentary 

SELECT @IDCOUNT = 
COUNT(*) -1
FROM Documentary

SELECT @RANDOM = FLOOR(RAND()*(@IDCOUNT-2+1))+2

DROP TABLE IF EXISTS #DocumentarioParaConhecer
SELECT @IDMAX+1 AS ID_ListDocumentary, Title, ID_Doc
INTO #DocumentarioParaConhecer
FROM Documentary
WHERE ID_Doc IN (@RANDOM , @RANDOM +1, @RANDOM -1)

INSERT INTO WatchlistDocumentary (ID_ListDocumentary,Name,ID_Doc)
SELECT *
FROM #DocumentarioParaConhecer


   END;  

