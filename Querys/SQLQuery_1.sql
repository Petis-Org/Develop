 CREATE TABLE PETS(
     ID INT NOT NULL,
     PETSHOP VARCHAR(40) NOT NULL,
     VACINAS BIT NOT NULL,
     CASTRACAO BIT NOT NULL,
     IDADE INT,
     PRIMARY KEY (ID)
 ) 

  CREATE TABLE PETSHOP(
     ID INT NOT NULL,
     PETSHOP VARCHAR(40) NOT NULL,
     AVALIACAO FLOAT NOT NULL,
     TELEFONE INT NOT NULL,
     ENDEREÇO NVARCHAR(40),
     PRIMARY KEY (ID)
 ) 

  CREATE TABLE VET(
     ID INT NOT NULL,
     NOME VARCHAR(50) NOT NULL,
     AVALIACAO FLOAT NOT NULL,
     TELEFONE INT NOT NULL,
     EMAIL VARCHAR(30),
     PRIMARY KEY (ID)
 ) 

 