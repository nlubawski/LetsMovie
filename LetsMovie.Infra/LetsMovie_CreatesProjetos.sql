

CREATE TABLE WatchListMovie
(  
 ID_WatchListMovie INT IDENTITY (1,1),
 ID_ListMovie INT DEFAULT 0,
 Name VARCHAR(40) NOT NULL,  
 ID_Movie INT
 CONSTRAINT PK_id_watchListMovie PRIMARY KEY(ID_WatchListMovie),
); 


CREATE TABLE WatchListSerie
(  
 ID_WatchListSerie INT IDENTITY (1,1),
  ID_ListSerie INT DEFAULT 0,
 Name VARCHAR(40) NOT NULL,  
 ID_Serie INT,
 CONSTRAINT PK_id_watchListSerie PRIMARY KEY(ID_WatchListSerie),
); 

CREATE TABLE WatchListDocumentary
(  
 ID_WatchListDocumentary INT IDENTITY (1,1),
  ID_ListDocumentary INT DEFAULT 0,
 Name VARCHAR(40) NOT NULL,  
 ID_Doc INT,
 CONSTRAINT PK_id_watchListDocumentary PRIMARY KEY(ID_WatchListDocumentary),
); 


CREATE TABLE Movie 
( 
 ID_Movie INT IDENTITY (1,1), 
 Title VARCHAR(100) NOT NULL,   
 Gender VARCHAR(20) CHECK (Gender IN ('Romance', 'Horror', 'Action', 'Adventure', 'Heroes', 'Comedy', 'Romantic Comedy')),  
 DateOfRelease DATE NOT NULL,
 CONSTRAINT PK_id_movie PRIMARY KEY(ID_Movie),
); 

CREATE TABLE Documentary 
( 
 ID_Doc INT IDENTITY (1,1),
 Title VARCHAR(100) NOT NULL,
 Country VARCHAR(40) CHECK (Country IN ('Brazil', 'USA', 'European Movie', 'Asiatic Movie', 'LatinAmerica Movie', 'African Movie')),    
 ID_Prod INT,
 CONSTRAINT PK_id_doc PRIMARY KEY (ID_Doc),
); 


CREATE TABLE Serie 
( 
 ID_Serie INT IDENTITY (1,1),
 Title VARCHAR(100) NOT NULL,  
 Season INT NOT NULL, 
 NumberOfEpisode INT,  
 CONSTRAINT PK_id_serie PRIMARY KEY (ID_Serie),
); 

CREATE TABLE Producer 
( 
 ID_Prod INT IDENTITY (1,1),
 Name VARCHAR(100) NOT NULL,
 UNIQUE (Name),
 CONSTRAINT PK_id_prod PRIMARY KEY (ID_Prod),
); 

CREATE TABLE PrincipalActor 
( 
 ID_Actor INT IDENTITY (1,1),
 Name VARCHAR(100) NOT NULL,  
 CONSTRAINT PK_id_actor PRIMARY KEY (ID_Actor),
); 


CREATE TABLE Episode 
( 
 ID_Episode INT IDENTITY(1,1),
 Title VARCHAR(100) NOT NULL,  
 NumberOfSeasonsEpisode INT,  
 ID_Serie INT,
 CONSTRAINT PK_id_episode PRIMARY KEY (ID_Episode),
); 

CREATE TABLE Act 
( 
 Role VARCHAR(40) NOT NULL,
 ID_Actor INT,
 ID_Movie INT,
); 


ALTER TABLE WatchListMovie ADD FOREIGN KEY(ID_Movie) REFERENCES Movie (ID_Movie)
ALTER TABLE WatchListDocumentary ADD FOREIGN KEY(ID_Doc) REFERENCES Documentary (ID_Doc)
ALTER TABLE WatchListSerie ADD FOREIGN KEY(ID_Serie) REFERENCES Serie (ID_Serie)
ALTER TABLE Documentary ADD FOREIGN KEY(ID_Prod) REFERENCES Producer (ID_Prod)
ALTER TABLE Episode ADD FOREIGN KEY(ID_Serie) REFERENCES Serie (ID_Serie)
ALTER TABLE Act ADD FOREIGN KEY(ID_Movie) REFERENCES Movie (ID_Movie)
ALTER TABLE Act ADD FOREIGN KEY(ID_Actor) REFERENCES PrincipalActor (ID_Actor) 