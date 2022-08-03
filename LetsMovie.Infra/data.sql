/* =========================================================================
=                                                                          = 
=                                                                          = 
=                      COMANDOS - CRIAÇÂO DAS TABELAS  E		     	   =
=				 	        UPDATE DAS FOREIGN KEY                         =
=                               DATA: 30/07/2022                           = 
=                                                                          =
=                                                                          =
=                                                                          =   
============================================================================*/

CREATE TABLE WatchListMovie
(  
 ID_WatchListMovie INT IDENTITY (1,1),
 ID_ListMovie INT DEFAULT 0,
 Name VARCHAR(40) NOT NULL,  
 ID_Movie INT
 CONSTRAINT PK_id_watchListMovie PRIMARY KEY(ID_WatchListMovie),
);
GO

CREATE TABLE WatchListSerie
(  
 ID_WatchListSerie INT IDENTITY (1,1),
  ID_ListSerie INT DEFAULT 0,
 Name VARCHAR(40) NOT NULL,  
 ID_Serie INT,
 CONSTRAINT PK_id_watchListSerie PRIMARY KEY(ID_WatchListSerie),
);
GO

CREATE TABLE WatchListDocumentary
(  
 ID_WatchListDocumentary INT IDENTITY (1,1),
  ID_ListDocumentary INT DEFAULT 0,
 Name VARCHAR(40) NOT NULL,  
 ID_Doc INT,
 CONSTRAINT PK_id_watchListDocumentary PRIMARY KEY(ID_WatchListDocumentary),
);
GO

CREATE TABLE Movie 
( 
 ID_Movie INT IDENTITY (1,1), 
 Title VARCHAR(100) NOT NULL,   
 Gender VARCHAR(20) CHECK (Gender IN ('Romance', 'Horror', 'Action', 'Adventure', 'Heroes', 'Comedy', 'Romantic Comedy')),  
 DateOfRelease DATE NOT NULL,
 CONSTRAINT PK_id_movie PRIMARY KEY(ID_Movie),
); 
GO

CREATE TABLE Documentary 
( 
 ID_Doc INT IDENTITY (1,1),
 Title VARCHAR(100) NOT NULL,
 Country VARCHAR(40) CHECK (Country IN ('Brazil', 'USA', 'European Movie', 'Asiatic Movie', 'LatinAmerica Movie', 'African Movie')),    
 ID_Prod INT,
 CONSTRAINT PK_id_doc PRIMARY KEY (ID_Doc),
);
GO

CREATE TABLE Serie 
( 
 ID_Serie INT IDENTITY (1,1),
 Title VARCHAR(100) NOT NULL,  
 Season INT NOT NULL, 
 NumberOfEpisode INT,  
 CONSTRAINT PK_id_serie PRIMARY KEY (ID_Serie),
);
GO

CREATE TABLE Producer 
( 
 ID_Prod INT IDENTITY (1,1),
 Name VARCHAR(100) NOT NULL,
 UNIQUE (Name),
 CONSTRAINT PK_id_prod PRIMARY KEY (ID_Prod),
); 
GO

CREATE TABLE PrincipalActor 
( 
 ID_Actor INT IDENTITY (1,1),
 Name VARCHAR(100) NOT NULL,  
 CONSTRAINT PK_id_actor PRIMARY KEY (ID_Actor),
); 
GO

CREATE TABLE Episode 
( 
 ID_Episode INT IDENTITY(1,1),
 Title VARCHAR(100) NOT NULL,  
 NumberOfSeasonsEpisode INT,  
 ID_Serie INT,
 CONSTRAINT PK_id_episode PRIMARY KEY (ID_Episode),
); 
GO

CREATE TABLE Act 
( 
 Role VARCHAR(40) NOT NULL,
 ID_Actor INT,
 ID_Movie INT,
); 
GO

ALTER TABLE WatchListMovie ADD FOREIGN KEY(ID_Movie) REFERENCES Movie (ID_Movie);
ALTER TABLE WatchListDocumentary ADD FOREIGN KEY(ID_Doc) REFERENCES Documentary (ID_Doc);
ALTER TABLE WatchListSerie ADD FOREIGN KEY(ID_Serie) REFERENCES Serie (ID_Serie);
ALTER TABLE Documentary ADD FOREIGN KEY(ID_Prod) REFERENCES Producer (ID_Prod);
ALTER TABLE Episode ADD FOREIGN KEY(ID_Serie) REFERENCES Serie (ID_Serie);
ALTER TABLE Act ADD FOREIGN KEY(ID_Movie) REFERENCES Movie (ID_Movie);
ALTER TABLE Act ADD FOREIGN KEY(ID_Actor) REFERENCES PrincipalActor (ID_Actor);


/* =========================================================================
=                                                                          = 
=                                                                          = 
=          COMANDOS - INSERÇÃO DE DADOS E RELACIONAMENTO                   =
=                           DATA: 31/07/2022                               = 
=                                                                          =
=                                                                          =
=                                                                          =   
============================================================================*/



/* 
   ================= Tables =================
      ** Documentary AND Producer **
*/

-- Documentary - INSERT

INSERT INTO Documentary (Title, Country) VALUES ('Harry Potter - 20 anos de magia: De Volta a Hogwarts','USA')
INSERT INTO Documentary (Title, Country) VALUES ('Bijagós - O tesouro sagrado','African Movie')
INSERT INTO Documentary (Title, Country) VALUES ('A marcha dos Pinguins','European Movie')
INSERT INTO Documentary (Title, Country) VALUES ('Ilha das Flores','Brazil')
INSERT INTO Documentary (Title, Country) VALUES ('Little miss sumô','Asiatic Movie')
INSERT INTO Documentary (Title, Country) VALUES ('¿Onde Está América Latina?','LatinAmerica Movie')

-- Producer - INSERT

INSERT INTO Producer (Name) VALUES ('NetFlix')
INSERT INTO Producer (Name) VALUES ('Sussuarana Filmes')
INSERT INTO Producer (Name) VALUES ('Casa de Cinema de Porto Alegre ')
INSERT INTO Producer (Name) VALUES ('Buena Vista International')
INSERT INTO Producer (Name) VALUES ('CPLP Audiovisual')
INSERT INTO Producer (Name) VALUES ('Casey Patterson Entertainment')

-- Documentary - UPDATE

UPDATE Documentary 
SET ID_Prod = 6
WHERE Title = 'Harry Potter - 20 anos de magia: De Volta a Hogwarts'

UPDATE Documentary 
SET ID_Prod = 5
WHERE Title = 'Bijagós - O tesouro sagrado'

UPDATE Documentary 
SET ID_Prod = 4
WHERE Title = 'A marcha dos Pinguins'

UPDATE Documentary 
SET ID_Prod = 3
WHERE Title = 'Ilha das Flores '

UPDATE Documentary 
SET ID_Prod = 1
WHERE Title = 'Little miss sumô'

UPDATE Documentary 
SET ID_Prod =4
WHERE Title = '¿Onde Está América Latina?'

-- Documentary / Producer - Conexão

SELECT *
from Documentary a
left join Producer b
ON a.ID_Prod = b.ID_Prod


/* ========================================================= */

/* 
   ================= Tables =================
      ** Principal Actor, Act AND Movie ***/

-- Movie
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('O Poderoso Chefão','Action','1972-03-24');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Thor: Amor e Trovão','Heroes','2022-07-07');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('V de vingança','Action','2006-04-07');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Diário de uma paixão','Romance','2004-08-13');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('O Exorcista','Horror','1974-06-29');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Indiana Jones: O reino da caveira de cristal','Adventure','2008-05-21');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('O auto  da compadecida','Comedy','2000-09-10');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('A verdade nua e crua','Romantic Comedy','2009-09-18');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Kill Bill - Volume 1', 'Action', '2004-04-23');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Kill Bill - Volume 2', 'Action', '2004-10-08');
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Mississipi em chamas','Action','1989-03-23');
GO
	  	   	   
-- Principal Actor

INSERT INTO PrincipalActor(Name) VALUES ('Al Pacino');
INSERT INTO PrincipalActor(Name) VALUES ('Ryan Gosling');
INSERT INTO PrincipalActor(Name) VALUES ('Matheus Nachtergaele');
INSERT INTO PrincipalActor(Name) VALUES ('Chris Hemsworth');
INSERT INTO PrincipalActor(Name) VALUES ('Natalie Portman');
INSERT INTO PrincipalActor(Name) VALUES ('Harisson Ford');
INSERT INTO PrincipalActor(Name) VALUES ('Linda Blair');
INSERT INTO PrincipalActor(Name) VALUES ('Katherine Heigl');
INSERT INTO PrincipalActor(Name) VALUES ('Uma Thurman');
INSERT INTO PrincipalActor(Name) VALUES ('David Carradine');
INSERT INTO PrincipalActor(Name) VALUES ('Willem Dafoe');
GO

-- Act

INSERT INTO Act(Role) VALUES ('Michael Corleone');
INSERT INTO Act(Role) VALUES ('Noah Júnior');
INSERT INTO Act(Role) VALUES ('Abby Richter');
INSERT INTO Act(Role) VALUES ('Thor');
INSERT INTO Act(Role) VALUES ('Indiana Jones');
INSERT INTO Act(Role) VALUES ('Regan MacNeil');
INSERT INTO Act(Role) VALUES ('João Grilo');
INSERT INTO Act(Role) VALUES ('Evey Rammond');
INSERT INTO Act(Role) VALUES ('Beatrix Kiddo');
INSERT INTO Act(Role) VALUES('Bill');
INSERT INTO Act(Role) VALUES ('Alan Ward');
GO

------ UPDATE ACT --------

UPDATE Act
SET ID_Actor = 5
WHERE Role = 'Evey Rammond';

UPDATE Act
SET ID_Movie = 3
WHERE Role = 'Evey Rammond';
GO

UPDATE Act
SET ID_Actor = 3
WHERE Role = 'João Grilo';

UPDATE Act
SET ID_Movie = 7
WHERE Role = 'João Grilo';
GO

UPDATE Act
SET ID_Actor = 7
WHERE Role = 'Regan MacNeil';

UPDATE Act
SET ID_Movie = 5
WHERE Role = 'Regan MacNeil';
GO

UPDATE Act
SET ID_Actor = 6
WHERE Role = 'Indiana Jones';

UPDATE Act
SET ID_Movie = 6
WHERE Role = 'Indiana Jones';
GO

UPDATE Act
SET ID_Actor = 4
WHERE Role = 'Thor';

UPDATE Act
SET ID_Movie = 2
WHERE Role = 'Thor';
GO

UPDATE Act
SET ID_Actor = 8
WHERE Role = 'Abby Richter';

UPDATE Act
SET ID_Movie = 8
WHERE Role = 'Abby Richter';
GO


UPDATE Act
SET ID_Actor = 2
WHERE Role = 'Noah Júnior';

UPDATE Act
SET ID_Movie = 4
WHERE Role = 'Noah Júnior';
GO

UPDATE Act
SET ID_Actor = 1
WHERE Role = 'Michael Corleone';

UPDATE Act
SET ID_Movie = 1
WHERE Role = 'Michael Corleone';
GO

UPDATE Act
SET ID_Actor = 10
WHERE Role ='Beatrix Kiddo';

UPDATE Act
SET ID_Movie = 12
WHERE Role = 'Beatrix Kiddo';
GO

UPDATE Act
SET ID_Actor = 11 
WHERE Role = 'Bill';

UPDATE Act
SET ID_Movie = 13
WHERE Role = 'Bill';
GO

UPDATE Act
SET ID_Actor = 12
WHERE Role = 'Alan Ward';
UPDATE Act
SET ID_Movie = 14
WHERE Role = 'Alan Ward';
GO

/* 
   ================= Tables =================
      ** Serie AND Episode ***/

INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Stranger Things','4','9');
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Game of Thrones','8','6');
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Bel-Air','1','10');
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('A Maldição da Residência Hill','1','10');
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Todo Mundo Odeia o Chris','4','22');
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Friends','10','18');
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Hannibal','3','13');
GO

-- Todo mundo Odeia o Chris

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Tattaglia','1','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Bolo','2','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Baile de Boas Vindas','3','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia A Professora de Literatura','4','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Meu Brother','5','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Docs','6','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia X-9','7','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Garotas Altas e Magras','8','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O James','9','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Véspera de Ano Novo','10','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Sr','11','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Lutadores Fracassados','12','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Identidades Falsas','13','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Exames para Faculdade','14','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Boxe','15','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Lasanha','16','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia A Semana da Primavera','17','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Carro','18','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Lavar a Louça','19','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Tasha','20','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Ameaças de Bomba','21','5');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Supletivo','22','5');
GO

-- Stranger Things

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo um: O Clube Hellfire','1','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo dois: A Maldição de Vecna','2','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo três: O monstro e a super-heroína','3','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo quatro: Querido Billy','4','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo cinco: Projeto Nina','5','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo seis: Mergulho','6','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo sete: O Massacre no Laboratório de Hawkings','7','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo oito: Papai','8','1');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo nove: E o Plano de Onze','9','1');
GO

-- Hannibal

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Apéritif','1','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Amuse-Bouche','2','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Potage','3','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Oeuf','4','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Coquilles','5','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Entrée','6','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Sorbet','7','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Fromage','8','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Trou Normand','9','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Buffet froid','10','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Rôti','11','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Relevés','12','7');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Savoureux ','13','7');
GO

-- Game of thrones

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Winterfell','1','2');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Uma Cavaleira dos Sete Reinos','2','2');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('A Longa Noite','3','2');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Os Últimos Starks','4','2');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('The Bells','5','2');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Trono de Ferro','6','2');
GO

-- Bel-Air

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Sonhos e Pesadelos','1','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Mantenha a Cabeça Erguida','2','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Yamacraw','3','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Campanha','4','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Da Pensilvânia para Los Angeles','5','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('A Força para Sorrir','6','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aqui se Faz Aqui se Paga','7','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Nínguem Ganha Quando a Família Briga','8','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Sem Trapaça','9','3');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Para Onde?','10','3');
GO

-- Friends

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele depois do Beijo do Joey e da Rachel','1','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que o Ross Está Legal','2','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Bronzeado do Ross','3','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Bolo','4','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele que a Irmã da Rachel Fica de Babá','5','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Bolsa de Estudos do Ross','6','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Balanço','7','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Ação de Graças Atrasado','8','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Mãe Biológica','9','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que o Chandler é Pego','10','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que o Stripper Chora','11','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Casamento de Phoebe','12','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que Joey Fala Francês','13','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Princesa Consuela','14','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que a Estelle Morre','15','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Festa de Despedida da Rachel','16','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Último - Parte 1','17','6');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Último - Parte 2 ','18','6');
GO

-- A Maldição da Residência Hill

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Steven Vê um Fantasma','1','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Caixão Aberto','2','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Toque','3','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Coisa de Gêmeos','4','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('A Moça do Pescoço Torto','5','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Duas Tempestades','6','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Eulogia','7','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Marcas de Uso','8','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Pesadelo','9','4');
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Silêncio Repousa Soberano','10','4');
GO

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
ON b.ID_Actor = c.ID_Actor;
GO

CREATE VIEW VwSeriesDisponiveis

AS

SELECT CONCAT('Todos os ', NumberOfEpisode, ' episódios da ',
Season,'ª temporada de "', Title, '" já estão disponíveis!') 
AS SeriesDisponiveis
FROM Serie; 
GO
           
CREATE VIEW VwDocNovos

AS

SELECT CONCAT('Lançamento do documentário "', a.Title, '"
produzido por ', b.Name,'.')
as DocNovos
FROM Documentary a
INNER JOIN Producer b
ON a.ID_Prod = b.ID_Prod; 
GO

/*==========================

STORED PROCEDURE

===========================*/

-- Filmes

CREATE PROCEDURE SpAtualizacaoFilmesNovosNoLetsMovie AS

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

END;
GO

-- Serie

CREATE PROCEDURE SpAtualizacaoSeriesMaratonar AS

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

END;
GO

-- Documentary

CREATE PROCEDURE SpDocumentarioParaConhecer AS

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
GO

-- Insere Ator e Papel 
CREATE PROCEDURE dbo.spInsertAct
(
@ROLE AS VARCHAR(40),
@title VARCHAR(100), 
@actor VARCHAR(100)
)
AS

DECLARE @ID_Movie INT, @ID_Actor INT 

SELECT  @ID_Movie = ID_Movie FROM Movie WHERE Title = @title

SELECT @ID_Actor = ID_Actor FROM PrincipalActor WHERE Name = @actor;

UPDATE Act
SET ID_Actor = @ID_Actor
WHERE Role = @ROLE

UPDATE Act
SET ID_MOVIE = @ID_Movie
WHERE Role = @ROLE



/*==========================

TRIGGER

===========================*/

CREATE TABLE Movie_logs
(
    id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    date_log DATETIME DEFAULT GETDATE() NOT NULL,
    command NCHAR(6) NOT NULL,
    previous_column VARCHAR(100) NULL,
    current_column VARCHAR(100) NULL,
    previous_value_column VARCHAR(100) NULL, 
    current_value_column  VARCHAR(100) NULL,
    user_made_change VARCHAR(100) NOT NULL
); 

CREATE TRIGGER dispara_logs
ON Movie
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @comando CHAR(6)
    SET @comando = CASE
        WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted)
            THEN 'Update'
        WHEN EXISTS(SELECT * FROM inserted)
            THEN 'Insert'
        WHEN EXISTS(SELECT * FROM deleted)
            THEN 'Delete'
        ELSE NULL
    END
    IF @comando = 'Delete'
        INSERT INTO Movie_logs (command, date_log, previous_title_column, previous_gender_column, user_made_change)
        SELECT @comando, GETDATE(), d.Title, d.Gender, USER_NAME() 
        FROM deleted AS d
    IF @comando = 'Insert'
        INSERT INTO Movie_logs (command, date_log, previous_title_column, previous_gender_column, user_made_change)
        SELECT @comando, GETDATE(), i.Title, i.Gender, USER_NAME() 
        FROM inserted AS i
    IF @comando = 'Update'
        INSERT INTO Movie_logs (command, date_log, previous_title_column, previous_gender_column, current_title_column, current_gender_column, user_made_change)
        SELECT @comando, GETDATE(), d.Title, d.Gender, i.Title, i.Gender, USER_NAME() 
        FROM deleted AS d, inserted  AS i
END

--Movie inserido pra teste 
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Um dia','Romance','2011-10-14');
INSERT INTO PrincipalActor(Name) VALUES ('Anne Hathaway ');
INSERT INTO Act(Role) VALUES ('Emma Morley ');
UPDATE Act
SET ID_Actor = 13
WHERE Role = 'Emma Morley ';
UPDATE Act
SET ID_Movie = 15
WHERE Role = 'Emma Morley ';
GO



