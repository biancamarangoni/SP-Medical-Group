USE SPMedicalGroup;
GO

INSERT INTO TipoUsuario(TituloTipoUsuario)
VALUES ('Administrador'),('M�dico'),('Paciente');
GO



INSERT INTO Endereco(Rua, Numero, Bairro, Cidade, Estado, CEP)
VALUES 
('Av. Bar�o Limeira', 532, 'Santa Cecilia', 'S�o Paulo', 'SP', '01202001'),
('R. Estado de Israel', 240, 'Jaragu�', 'S�o Paulo', 'SP', '04022000'),
('Av. Paulista', 1578, 'Centro', 'S�o Paulo', 'SP', '01310200'),
('Av. Ibirapuera', 2927, 'Centro', 'S�o Paulo', 'SP', '04029200'),
('R. Vit�ria', 120, 'Santa Cecilia', 'Barueri', 'SP', '06402030'),
('R. Ver. Geraldo de Camargo', 66, 'Santos', 'Ribeir�o Pires', 'SP', '09405380'),
('Alameda dos Arapan�s', 945, 'Santa Cecilia', 'S�o Paulo', 'SP', '04524001'),
('R Santo Antonio', 232, 'Perus', 'Barueri', 'SP', '06407140');
GO


INSERT INTO Especialidade(TituloEspecialidade)
VALUES ('Cardiologia'),('Cirurgia Cardiovascular'),
('Cirurgia Geral'),('Cirurgia Pl�stica'),
('Cirurgia Vascular'),('Dermatolgia'),('Radioterapia'),('Pediatria');
GO


INSERT INTO Clinica(IdEndereco, NomeFantasia ,CNPJ, RazaoSocial,
HorarioAbertura, HorarioFechamento)
VALUES (1,'Clinica Paulista', '86400902000130', 
'SP Medical Group', '08:00:00', '18:00:00');
GO



INSERT INTO Usuario(IdTipoUsuario, Email, Senha)
VALUES (2,'ricardo.lemos@spmedicalgroup.com.br', '126532'),(2,'roberto.possarle@spmedicalgroup.com.br', '128976'),(2,'helena.souza@spmedicalgroup.com.br','9832'),
(3,'ligia@gmail.com','1987029'),(3,'alexandre@gmail.com','klpoq731'),(3,'fernando@gmail.com','38762hd'),
(3,'henrique@gmail.com','3as7com3'),(3,'joao@hotmail.com','3457g0'),(3,'bruno@gmail.com','865234'),
(3,'mariana@outlook.com','13436'),(1,'administrador@gmail.com','123456');
GO


INSERT INTO Paciente(IdUsuario,IdEndereco,NomePaciente,DataNascimento, Telefone,RG,CPF)
VALUES (4, 2,'Ligia', '1983-10-13', '1134567654', '435225435','94839859000'),
(5,3, 'Alexandre', '2001-07-23', '11987656543','326543457', '73556944057'),
(6, 4, 'Fernando', '1978-10-10', '11972084453',	'546365253', '16839338002'),
(7, 5, 'Henrique', '1985-10-13', '1134566543', '543663625', '14332654765'),
(8, 6, 'Jo�o', '1975-08-27', '1176566377', '532544441', '91305348010'),
(9, 7, 'Bruno', '1972-03-21', '11954368769', '545662667', '79799299004'),
(10, 8, 'Mariana',	'2018-03-05', null	, '545662668', '13771913039');
GO


INSERT INTO Medico(IdUsuario, IdClinica, IdEspecialidade, NomeMedico, SobrenomeMedico, CRM)
VALUES (1, 1, 2, 'Ricardo',	'Lemos', '54356SP'),
(2, 1, 5,	'Roberto',  'Possarle',	'53452SP'),
(3, 1, 6,	'Helena', 'Strada',	'65463SP');
GO


INSERT INTO Situacao(Situacao)
VALUES ('Agendada'),('Realizada'),('Cancelada');
GO


INSERT INTO Consulta(IdPaciente, IdMedico, IdSituacao, DataConsulta, DescricaoConsulta)
VALUES (7, 3, 2, '20201020 03:00:00 PM', null),
(2, 2, 3, '20200601 10:00:00 AM', null),
(3, 2, 2, '20200702 11:00:00 AM', null),
(2, 2, 2, '20180602 10:00:00 AM', null),
(4, 1, 3, '20190702 11:00:00 AM', null),
(7, 3, 1, '20200803 03:00:00 PM', null),
(4, 1, 1, '20200903 11:00:00', null);
GO