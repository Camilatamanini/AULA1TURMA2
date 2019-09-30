insert into Usuarios -- Informamos a tabela que vamos reistrar o valor
(Nome) -- As colunas qye vamos carregas as informações
values -- informamos que os valores estarão a seguir
('Camila') -- nossas informações na ordem das colunas*/
GO
select * from Usuarios
GO
insert into Usuarios
(Nome, Login, Senha)
values
('Tito','Titozeras','123')
GO
select * from Usuarios