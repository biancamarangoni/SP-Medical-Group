
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
VALUES ('07987-022', 'SP', 'Osasco', 'Jardim das Flores', 'João Avelar', '598'),
	   ('35273-679', 'SP', 'São Paulo',	'Pinheiros', 'Rua das Pedras', '225'),
	   ('16372-256', 'SP',	'São Paulo', 'Jaraguá',	'Av. Alexio Jafet',	'847'),
	   ('16279-927', 'SP',	'Mogi das Cruzes', 'Vila Mogi Moderno', 'Francisco Urizzi',	'136'),
	   ('82629-055', 'SP',	'Caieras',	'Jardim São Francisco',	'Miguel Candido', '485'),
	   ('45783-823', 'SP',	'São Paulo', 'Perus', 'Rua da Ladeira', '96'),
	   ('21638-367', 'SP',	'São Paulo', 'Consolação',	'Av. Paulista',	'1274'),
		('26328-273', 'SP',	'Suzano', 'Vila Figueira',	'Av. Dos Santos', '903'),
		('21342-490', 'SP',	'Mogi das Cruzes',	'Vila Natal',	'Rua Charles Mion',	'378'),
		('95739-274', 'SP',	'Osasco', 'Pestana', 'Av. dos Bandeirantes', '563'),
		('36583-375', 'SP',	'Diadema',	'Jardim Elisa',	'Rua. Jaruga',	'103');
GO

