
USE SP_MEDICAL_GROUP
GO

INSERT INTO tipoUsuario (tituloTipoUsuario)
VALUES ('MEDICO'), ('ADMINISTRADOR'), ('PACIENTE');
GO

INSERT INTO Usuario (idTipoUsuario,nomeUsuario,email,senha)
VALUES (1, 'Saulo', 'saulo1@gmail.com', 'saulo182'),
	   (1, 'Julya', 'julya1@gmail.com', 'julya182'),
	   (3, 'Rafael', 'rafael1@gmail.com', 'rafael182'),
	   (2, 'Administrador', 'adm1@gmail.com','adm182'),
	   (3, 'Lucas', 'lucas1@gmail.com', 'lucas182'),
	   (3, 'Matheus', 'matheus1@gmail.com', 'matheus182'),
	   (3, 'Anna', 'anna1@gmail.com', 'anna182'),
	   (1, 'Laura', 'laura1@gmail.com', 'laura182'),
	   (1, 'Diego', 'diego1@gmail.com', 'diego182'),
	   (1, 'Luiz', 'luiz1@gmail.com', 'luiz182');
GO

INSERT INTO Endereco (CEP,estado,cidade,bairro,rua,numero)
VALUES ('87352-78', 'SP', 'Osasco', 'Jardim das Flores', 'João Avelar', '598'),
	   ('35273-79', 'SP', 'São Paulo',	'Pinheiros', 'Rua das Pedras', '225'),
	   ('16372-56', 'SP',	'São Paulo', 'Jaraguá',	'Av. Alexio Jafet',	'847'),
	   ('16279-27', 'SP',	'Mogi das Cruzes', 'Vila Mogi Moderno', 'Francisco Urizzi',	'136'),
	   ('82629-55', 'SP',	'Caieras',	'Jardim São Francisco',	'Miguel Candido', '485'),
	   ('45783-23', 'SP',	'São Paulo', 'Perus', 'Rua da Ladeira', '96'),
	   ('21438-67', 'SP',	'São Paulo', 'Consolação',	'Av. Paulista',	'1274'),
		('26328-73', 'SP',	'Suzano', 'Vila Figueira',	'Av. Dos Santos', '903'),
		('21342-90', 'SP',	'Mogi das Cruzes',	'Vila Natal',	'Rua Charles Mion',	'378'),
		('95739-74', 'SP',	'Osasco', 'Pestana', 'Av. dos Bandeirantes', '563'),
		('36583-75', 'SP',	'Diadema',	'Jardim Elisa',	'Rua. Jaruga',	'103');
GO

INSERT INTO Clinica (idEndereco,nomeFantasia,CNPJ,razaoSocial,horaAbertura,horaFechamento)
VALUES ('7', 'Clínica Paulista', '87293710092773','SP Medical Group', '8h', '22h');
GO

INSERT INTO Situacao (tipoStatus)
VALUES ('Confirmada'),
	   ('Cancelada');
GO

INSERT INTO Especialidade (nomeEspecialidade)
VALUES ('Pediatria'), ('Odontologia'), ('Gastrenterologia'), ('Infectologia'), ('Dermatologia');
GO

INSERT INTO Medico (idUsuario,idClinica,idEspecialidade,nomeMedico)
VALUES ('1', '1', '3', 'Saulo'),
	   ('2', '1', '4', 'Julya'),
	   ('8', '1', '1', 'Laura'),
	   ('9', '1', '5', 'Diego'),
	   ('10', '1', '2', 'Luiz');
GO

INSERT INTO Consulta (idPaciente,idMedico,idSituacao,dataConsulta)
VALUES ('2', '2', '1', '10/09/2021'),
	   ('4', '5', '1', '27/08/2021'),
	   ('1', '1', '2', '24/08/2021'),
	   ('3', '4', '1',	'05/09/2021');
GO


