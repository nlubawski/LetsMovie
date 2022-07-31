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

INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('O Poderoso Chefão','Action','1972-03-24')
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Thor: Amor e Trovão','Heroes','2022-07-07')
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('V de vingança','Action','2006-04-07')
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Diário de uma paixão','Romance','2004-08-13')
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('O Exorcista','Horror','1974-06-29')
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('Indiana Jones: O reino da caveira de cristal','Adventure','2008-05-21')
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('O auto  da compadecida','Comedy','2000-09-10')
INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES ('A verdade nua e crua','Romantic Comedy','2009-09-18')

	  	   	   
-- Principal Actor

INSERT INTO PrincipalActor(Name) VALUES ('Al Pacino')
INSERT INTO PrincipalActor(Name) VALUES ('Ryan Gosling')
INSERT INTO PrincipalActor(Name) VALUES ('Matheus Nachtergaele')
INSERT INTO PrincipalActor(Name) VALUES ('Chris Hemsworth')
INSERT INTO PrincipalActor(Name) VALUES ('Natalie Portman')
INSERT INTO PrincipalActor(Name) VALUES ('Harisson Ford')
INSERT INTO PrincipalActor(Name) VALUES ('Linda Blair')
INSERT INTO PrincipalActor(Name) VALUES ('Katherine Heigl')

-- Act

INSERT INTO Act(Role) VALUES ('Michael Corleone')
INSERT INTO Act(Role) VALUES ('Noah Júnior')
INSERT INTO Act(Role) VALUES ('Abby Richter')
INSERT INTO Act(Role) VALUES ('Thor')
INSERT INTO Act(Role) VALUES ('Indiana Jones')
INSERT INTO Act(Role) VALUES ('Regan MacNeil')
INSERT INTO Act(Role) VALUES ('João Grilo')
INSERT INTO Act(Role) VALUES ('Evey Rammond')


------ UPDATE ACT --------

UPDATE Act
SET ID_Actor = 5
WHERE Role = 'Evey Rammond'

UPDATE Act
SET ID_Movie = 3
WHERE Role = 'Evey Rammond'



UPDATE Act
SET ID_Actor = 3
WHERE Role = 'João Grilo'

UPDATE Act
SET ID_Movie = 7
WHERE Role = 'João Grilo'



UPDATE Act
SET ID_Actor = 7
WHERE Role = 'Regan MacNeil'

UPDATE Act
SET ID_Movie = 5
WHERE Role = 'Regan MacNeil'



UPDATE Act
SET ID_Actor = 6
WHERE Role = 'Indiana Jones'

UPDATE Act
SET ID_Movie = 6
WHERE Role = 'Indiana Jones'



UPDATE Act
SET ID_Actor = 4
WHERE Role = 'Thor'

UPDATE Act
SET ID_Movie = 2
WHERE Role = 'Thor'




UPDATE Act
SET ID_Actor = 8
WHERE Role = 'Abby Richter'

UPDATE Act
SET ID_Movie = 8
WHERE Role = 'Abby Richter'



UPDATE Act
SET ID_Actor = 2
WHERE Role = 'Noah Júnior'

UPDATE Act
SET ID_Movie = 4
WHERE Role = 'Noah Júnior'



UPDATE Act
SET ID_Actor = 1
WHERE Role = 'Michael Corleone'

UPDATE Act
SET ID_Movie = 1
WHERE Role = 'Michael Corleone'

/* 
   ================= Tables =================
      ** Serie AND Episode ***/

INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Stranger Things','4','9')
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Game of Thrones','8','6')
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Bel-Air','1','10')
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('A Maldição da Residência Hill','1','10')
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Todo Mundo Odeia o Chris','4','22')
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Friends','10','18')
INSERT INTO Serie (Title,Season, NumberOfEpisode) VALUES ('Hannibal','3','13')


-- Todo mundo Odeia o Chris

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Tattaglia','1','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Bolo','2','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Baile de Boas Vindas','3','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia A Professora de Literatura','4','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Meu Brother','5','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Docs','6','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia X-9','7','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Garotas Altas e Magras','8','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O James','9','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Véspera de Ano Novo','10','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Sr','11','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Lutadores Fracassados','12','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Identidades Falsas','13','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Exames para Faculdade','14','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Boxe','15','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Lasanha','16','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia A Semana da Primavera','17','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Carro','18','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Lavar a Louça','19','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Tasha','20','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia Ameaças de Bomba','21','5')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Todo Mundo Odeia O Supletivo','22','5')


-- Stranger Things

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo um: O Clube Hellfire','1','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo dois: A Maldição de Vecna','2','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo três: O monstro e a super-heroína','3','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo quatro: Querido Billy','4','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo cinco: Projeto Nina','5','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo seis: Mergulho','6','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo sete: O Massacre no Laboratório de Hawkings','7','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo oito: Papai','8','1')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Capítulo nove: E o Plano de Onze','9','1')

-- Hannibal

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Apéritif','1','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Amuse-Bouche','2','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Potage','3','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Oeuf','4','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Coquilles','5','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Entrée','6','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Sorbet','7','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Fromage','8','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Trou Normand','9','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Buffet froid','10','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Rôti','11','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Relevés','12','7')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Savoureux ','13','7')

-- Game of thrones

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Winterfell','1','2')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Uma Cavaleira dos Sete Reinos','2','2')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('A Longa Noite','3','2')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Os Últimos Starks','4','2')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('The Bells','5','2')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Trono de Ferro','6','2')

-- Bel-Air

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Sonhos e Pesadelos','1','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Mantenha a Cabeça Erguida','2','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Yamacraw','3','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Campanha','4','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Da Pensilvânia para Los Angeles','5','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('A Força para Sorrir','6','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aqui se Faz Aqui se Paga','7','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Nínguem Ganha Quando a Família Briga','8','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Sem Trapaça','9','3')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Para Onde?','10','3')


-- Friends

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele depois do Beijo do Joey e da Rachel','1','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que o Ross Está Legal','2','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Bronzeado do Ross','3','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Bolo','4','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele que a Irmã da Rachel Fica de Babá','5','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Bolsa de Estudos do Ross','6','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Balanço','7','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Ação de Graças Atrasado','8','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Mãe Biológica','9','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que o Chandler é Pego','10','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que o Stripper Chora','11','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com o Casamento de Phoebe','12','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que Joey Fala Francês','13','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Princesa Consuela','14','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele em que a Estelle Morre','15','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Aquele com a Festa de Despedida da Rachel','16','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Último - Parte 1','17','6')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Último - Parte 2 ','18','6')


-- A Maldição da Residência Hill

INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Steven Vê um Fantasma','1','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Caixão Aberto','2','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Toque','3','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Coisa de Gêmeos','4','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('A Moça do Pescoço Torto','5','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Duas Tempestades','6','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Eulogia','7','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Marcas de Uso','8','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('Pesadelo','9','4')
INSERT INTO Episode  (Title,NumberOfSeasonsEpisode, ID_Serie) VALUES ('O Silêncio Repousa Soberano','10','4')


