Create Database dev_db

Use dev_db

create table Professores(
ProfessorId int primary key identity,
Nome varchar(255),
Email varchar(255),
Senha varchar (255)
)

create table Turmas(
TurmaId int primary key identity,
Nome varchar(255),
ProfessorId int,
Foreign key (ProfessorId) references Professores(ProfessorId)
)

create table Atividades(
AtividadeId int primary key identity,
Descricao varchar(255),
TurmaId int,
Foreign key (TurmaId) references Turmas(TurmaId)
)


insert into Professores(Nome, Email, Senha) values
('Joao Alves', 'jalves@gmail.com','admin123'),
('Wandinho', 'wandinha@gmail.com','admin123'),
('Tio Marcio', 'tio@gmail.com','admin123')


insert into Turmas (Nome, ProfessorId) values
('Desenvolvimento', 1),
('Redes', 2),
('IoT', 3)


insert into Atividades (Descricao, TurmaId) values
('Crud', 1),
('Simulado Saeb', 2),
('CTF', 3)
