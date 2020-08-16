# HouseHotelSystem
This project is reference to my TCC at ETEC Ruth Cardoso
Note que precisa necessáriamente de uma base de dados, essa abaixo deve ser o suficiente, pegue CPF para cadastro e teste
---------------------------------------------------------------------------------------------------------------------------



-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.45-log


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema db_hotel_att2
--

CREATE DATABASE IF NOT EXISTS db_hotel_att2;
USE db_hotel_att2;

--
-- Definition of table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
CREATE TABLE `tb_cliente` (
  `cd_cpf` varchar(20) NOT NULL,
  `nm_cliente` varchar(45) DEFAULT NULL,
  `dt_nascimento` date DEFAULT NULL,
  `cd_passaporte` varchar(20) DEFAULT NULL,
  `nm_nacionalidade` varchar(45) DEFAULT NULL,
  `vl_gastos` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`cd_cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_cliente`
--

/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` (`cd_cpf`,`nm_cliente`,`dt_nascimento`,`cd_passaporte`,`nm_nacionalidade`,`vl_gastos`) VALUES 
 ('326-661-162-47','Aluizio Oliveira','1985-04-13','oo0000000','Brasileiro','53.99'),
 ('450-472-678-57','Matheus Figueira','1997-05-27','oo0000000','Brasileira','50.00');
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;


--
-- Definition of table `tb_contato`
--

DROP TABLE IF EXISTS `tb_contato`;
CREATE TABLE `tb_contato` (
  `cd_cel` varchar(20) NOT NULL,
  `cd_tel` varchar(20) DEFAULT NULL,
  `nm_email` varchar(45) DEFAULT NULL,
  `ds_obs_contato` varchar(100) DEFAULT NULL,
  `cd_cpf_cliente` varchar(20) DEFAULT NULL,
  `cd_cpf_func` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`cd_cel`),
  KEY `fk_cliente_contato` (`cd_cpf_cliente`),
  KEY `fk_func_contato` (`cd_cpf_func`),
  CONSTRAINT `fk_cliente_contato` FOREIGN KEY (`cd_cpf_cliente`) REFERENCES `tb_cliente` (`cd_cpf`),
  CONSTRAINT `fk_func_contato` FOREIGN KEY (`cd_cpf_func`) REFERENCES `tb_funcionario` (`cd_cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_contato`
--

/*!40000 ALTER TABLE `tb_contato` DISABLE KEYS */;
INSERT INTO `tb_contato` (`cd_cel`,`cd_tel`,`nm_email`,`ds_obs_contato`,`cd_cpf_cliente`,`cd_cpf_func`) VALUES 
 (' (13) 9963-91744','(13) 3395-3309','aluizio@gmail.com',NULL,'326-661-162-47',NULL),
 (' (13) 9967-39338','(13) 3365-5874','matheusfigueirang@gmail.com',NULL,'450-472-678-57',NULL),
 ('(13)99639-1744','(13)3395-3309','caiohr2020@gmail.com','Teste',NULL,'159-006-587-59');
/*!40000 ALTER TABLE `tb_contato` ENABLE KEYS */;


--
-- Definition of table `tb_endereco`
--

DROP TABLE IF EXISTS `tb_endereco`;
CREATE TABLE `tb_endereco` (
  `cd_endereco` varchar(20) DEFAULT NULL,
  `nm_endereco` varchar(100) DEFAULT NULL,
  `cd_cep` varchar(20) NOT NULL,
  `nm_cidade` varchar(100) DEFAULT NULL,
  `sg_uf` varchar(2) DEFAULT NULL,
  `nm_bairro` varchar(100) DEFAULT NULL,
  `nm_pais` varchar(45) DEFAULT NULL,
  `cd_cpf_cliente` varchar(20) DEFAULT NULL,
  `cd_cpf_func` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`cd_cep`),
  KEY `fk_cliente_endereco` (`cd_cpf_cliente`),
  KEY `fk_func_endereco` (`cd_cpf_func`),
  CONSTRAINT `fk_cliente_endereco` FOREIGN KEY (`cd_cpf_cliente`) REFERENCES `tb_cliente` (`cd_cpf`),
  CONSTRAINT `fk_func_endereco` FOREIGN KEY (`cd_cpf_func`) REFERENCES `tb_funcionario` (`cd_cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_endereco`
--

/*!40000 ALTER TABLE `tb_endereco` DISABLE KEYS */;
INSERT INTO `tb_endereco` (`cd_endereco`,`nm_endereco`,`cd_cep`,`nm_cidade`,`sg_uf`,`nm_bairro`,`nm_pais`,`cd_cpf_cliente`,`cd_cpf_func`) VALUES 
 ('553','praça 22 de janeiro','11310-090','São Vicente','SP','Biquinha','Brasil',NULL,'159-006-587-59'),
 ('11','Rua Visconde de Tamandaré','11310-441','São Vicente','SP','Centro','Brasil','450-472-678-57',NULL),
 ('254','Rua tres','11545-545','São Vicente','SP','Centro','Brasil','326-661-162-47',NULL);
/*!40000 ALTER TABLE `tb_endereco` ENABLE KEYS */;


--
-- Definition of table `tb_funcionario`
--

DROP TABLE IF EXISTS `tb_funcionario`;
CREATE TABLE `tb_funcionario` (
  `cd_cpf` varchar(20) NOT NULL,
  `nm_funcionario` varchar(45) DEFAULT NULL,
  `nm_login` varchar(45) DEFAULT NULL,
  `ds_senha` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cd_cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_funcionario`
--

/*!40000 ALTER TABLE `tb_funcionario` DISABLE KEYS */;
INSERT INTO `tb_funcionario` (`cd_cpf`,`nm_funcionario`,`nm_login`,`ds_senha`) VALUES 
 ('159-006-587-59','Caio Henrique','caio123','123');
/*!40000 ALTER TABLE `tb_funcionario` ENABLE KEYS */;


--
-- Definition of table `tb_menu`
--

DROP TABLE IF EXISTS `tb_menu`;
CREATE TABLE `tb_menu` (
  `cd_produto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nm_produto` varchar(60) DEFAULT NULL,
  `vl_produto` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`cd_produto`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_menu`
--

/*!40000 ALTER TABLE `tb_menu` DISABLE KEYS */;
INSERT INTO `tb_menu` (`cd_produto`,`nm_produto`,`vl_produto`) VALUES 
 (1,'Bolacha','2.99'),
 (2,'Toddy','3.99'),
 (3,'Miojo','3.99'),
 (4,'Iogurte','4.99'),
 (5,'Bolos','5.99'),
 (6,'Requeijão','6.99'),
 (7,'Água engarrafada','2.99'),
 (8,'Suco','5.99'),
 (9,'Café','3.98'),
 (10,'Chá','2.99'),
 (11,'Batata Frita','8.99');
/*!40000 ALTER TABLE `tb_menu` ENABLE KEYS */;


--
-- Definition of table `tb_quarto`
--

DROP TABLE IF EXISTS `tb_quarto`;
CREATE TABLE `tb_quarto` (
  `cd_quarto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nm_quarto` varchar(100) DEFAULT NULL,
  `ds_quarto` varchar(100) DEFAULT NULL,
  `ds_disponibilidade` varchar(100) DEFAULT NULL,
  `ds_situacao` varchar(100) DEFAULT NULL,
  `cd_cpf_cliente` varchar(20) DEFAULT NULL,
  `cd_reserva` varchar(100) DEFAULT NULL,
  `nm_categoria` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cd_quarto`),
  KEY `fk_cliente_quarto` (`cd_cpf_cliente`),
  KEY `fk_reserva_quarto` (`cd_reserva`),
  CONSTRAINT `fk_cliente_quarto` FOREIGN KEY (`cd_cpf_cliente`) REFERENCES `tb_cliente` (`cd_cpf`),
  CONSTRAINT `fk_reserva_quarto` FOREIGN KEY (`cd_reserva`) REFERENCES `tb_reserva` (`cd_reserva`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_quarto`
--

/*!40000 ALTER TABLE `tb_quarto` DISABLE KEYS */;
INSERT INTO `tb_quarto` (`cd_quarto`,`nm_quarto`,`ds_quarto`,`ds_disponibilidade`,`ds_situacao`,`cd_cpf_cliente`,`cd_reserva`,`nm_categoria`) VALUES 
 (1,'Quarto 01','Quarto para uma pessoa','Ocupado','Limpo','450-472-678-57','08122015162546','quarto solteiro'),
 (2,'Quarto 02','Quarto para duas pessoas','Ocupado','Limpo','326-661-162-47','08122015172204','quarto duplo solteiro'),
 (3,'Quarto 03','Quarto para duas pessoas','Ocupado','Limpo',NULL,NULL,'quarto casal'),
 (4,'Quarto 04','Quarto para 1 pessoa','Disponivel','Limpo',NULL,NULL,'quarto solteiro');
/*!40000 ALTER TABLE `tb_quarto` ENABLE KEYS */;


--
-- Definition of table `tb_reserva`
--

DROP TABLE IF EXISTS `tb_reserva`;
CREATE TABLE `tb_reserva` (
  `cd_reserva` varchar(100) NOT NULL,
  `dt_check_in` date DEFAULT NULL,
  `dt_check_out` date DEFAULT NULL,
  `qt_hospede` varchar(45) DEFAULT NULL,
  `ds_obs_reserva` varchar(100) DEFAULT NULL,
  `vl_diaria` decimal(9,2) DEFAULT NULL,
  `cd_cpf_cliente` varchar(20) DEFAULT NULL,
  `cd_cpf_func` varchar(20) DEFAULT NULL,
  `hr_check_in` time DEFAULT NULL,
  `hr_check_out` time NOT NULL,
  PRIMARY KEY (`cd_reserva`),
  KEY `fk_cliente_reserva` (`cd_cpf_cliente`),
  KEY `fk_funcionario_reserva` (`cd_cpf_func`),
  CONSTRAINT `fk_cliente_reserva` FOREIGN KEY (`cd_cpf_cliente`) REFERENCES `tb_cliente` (`cd_cpf`),
  CONSTRAINT `fk_funcionario_reserva` FOREIGN KEY (`cd_cpf_func`) REFERENCES `tb_funcionario` (`cd_cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_reserva`
--

/*!40000 ALTER TABLE `tb_reserva` DISABLE KEYS */;
INSERT INTO `tb_reserva` (`cd_reserva`,`dt_check_in`,`dt_check_out`,`qt_hospede`,`ds_obs_reserva`,`vl_diaria`,`cd_cpf_cliente`,`cd_cpf_func`,`hr_check_in`,`hr_check_out`) VALUES 
 ('08122015162546','2015-12-07','2015-12-08','1','Teste','50.00','450-472-678-57',NULL,'13:00:00','13:00:00'),
 ('08122015172204','2015-12-07','2015-12-08','1','teste','50.00','326-661-162-47',NULL,'18:00:00','13:00:00');
/*!40000 ALTER TABLE `tb_reserva` ENABLE KEYS */;


--
-- Definition of procedure `adc_produto_conta`
--

DROP PROCEDURE IF EXISTS `adc_produto_conta`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `adc_produto_conta`(in produto varchar(60), cpf varchar(20))
begin
declare gastos decimal(9,2);
    select vl_produto into gastos from tb_menu where nm_produto = produto;
    update tb_cliente set vl_gastos = vl_gastos + gastos where cd_cpf = cpf;
end $$

DELIMITER ;

--
-- Definition of procedure `ht_cardapio`
--

DROP PROCEDURE IF EXISTS `ht_cardapio`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_cardapio`()
begin
    select cd_produto as 'Codigo', nm_produto as 'Produto', vl_produto as 'Valor' from tb_menu;
end $$

DELIMITER ;

--
-- Definition of procedure `ht_cliente`
--

DROP PROCEDURE IF EXISTS `ht_cliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_cliente`(nome varchar(100))
begin
        select nm_cliente, cd_cpf, vl_gastos, cd_cep, nm_cidade, cd_passaporte from tb_cliete where nm_cliente = nome;
end $$

DELIMITER ;

--
-- Definition of procedure `ht_cria_quarto`
--

DROP PROCEDURE IF EXISTS `ht_cria_quarto`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_cria_quarto`(
codquarto int,
nomequarto varchar(100),
descricaoQuarto varchar(50),
situacao varchar(100),
categoria varchar(45),
disponibilidade varchar(20)
)
begin
    if exists(select nm_quarto from tb_quarto where nm_quarto = nomequarto) then
      select concat('n funfo') as Atenção;

    else

      insert into tb_quarto (cd_quarto,nm_quarto, ds_quarto, ds_situacao, nm_categoria, ds_disponibilidade ) values
          (codquarto,nomequarto, descricaoQuarto,situacao,categoria, disponibilidade);
            select concat('funfo') as informação;
   end if;
    end $$

DELIMITER ;

--
-- Definition of procedure `ht_dados_func`
--

DROP PROCEDURE IF EXISTS `ht_dados_func`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_dados_func`()
begin
      select tb_funcionario.cd_cpf, nm_funcionario,nm_login,ds_senha, tb_endereco.cd_endereco, nm_endereco, cd_cep, nm_cidade
        from tb_funcionario inner join tb_endereco
          on tb_funcionario.cd_cpf = tb_endereco.cd_cpf_func
            order by nm_funcionario asc;
    end $$

DELIMITER ;

--
-- Definition of procedure `ht_dados_funcionario`
--

DROP PROCEDURE IF EXISTS `ht_dados_funcionario`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_dados_funcionario`(nome varchar(100))
begin
        select tb_funcionario.cd_cpf, tb_funcionario.nm_funcionario, tb_funcionario.nm_login, tb_funcionario.ds_senha, tb_endereco.cd_endereco, tb_endereco.nm_endereco, tb_endereco.cd_cep, tb_endereco.nm_cidade
        from tb_funcionario inner join tb_endereco
          on tb_funcionario.cd_cpf = tb_endereco.cd_cpf_func
             where nm_funcionario = nome;
end $$

DELIMITER ;

--
-- Definition of procedure `ht_deleta_cliente`
--

DROP PROCEDURE IF EXISTS `ht_deleta_cliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_deleta_cliente`(in cpf varchar(20))
begin
update tb_quarto set cd_reserva = null where cd_cpf_cliente = cpf;
delete from tb_reserva where cd_cpf_cliente = cpf;
delete from tb_contato where cd_cpf_cliente = cpf;
delete from tb_endereco where cd_cpf_cliente = cpf;
update tb_quarto set cd_cpf_cliente = null where cd_cpf_cliente = cpf;
delete from tb_cliente where cd_cpf = cpf;

end $$

DELIMITER ;

--
-- Definition of procedure `ht_deleta_quarto`
--

DROP PROCEDURE IF EXISTS `ht_deleta_quarto`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_deleta_quarto`(
in nomequarto varchar(100)

)
begin

delete from tb_quarto where nm_quarto = nomequarto;
alter table tb_quarto drop cd_quarto;
alter table tb_quarto auto_increment = 1;
alter table tb_quarto add cd_quarto int unsigned not null auto_increment primary key first;




end $$

DELIMITER ;

--
-- Definition of procedure `ht_exibe_combobox`
--

DROP PROCEDURE IF EXISTS `ht_exibe_combobox`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_exibe_combobox`()
begin
  select cd_quarto from tb_quarto where cd_cpf_cliente is null order by cd_quarto asc;
end $$

DELIMITER ;

--
-- Definition of procedure `ht_exibe_quartos`
--

DROP PROCEDURE IF EXISTS `ht_exibe_quartos`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_exibe_quartos`()
begin
  select cd_quarto from tb_quarto;
end $$

DELIMITER ;

--
-- Definition of procedure `ht_exibe_saida`
--

DROP PROCEDURE IF EXISTS `ht_exibe_saida`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_exibe_saida`()
begin
      select tb_cliente.nm_cliente, tb_cliente.vl_gastos, tb_reserva.hr_check_out, tb_cliente.cd_cpf
        from tb_cliente inner join tb_reserva
          on tb_cliente.cd_cpf = tb_reserva.cd_cpf_cliente where dt_check_out = (select curdate());
end $$

DELIMITER ;

--
-- Definition of procedure `ht_notificacao`
--

DROP PROCEDURE IF EXISTS `ht_notificacao`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_notificacao`()
begin
  select dt_check_out from tb_reserva where dt_check_out = (select curdate());

end $$

DELIMITER ;

--
-- Definition of procedure `ht_pagamento_cliente`
--

DROP PROCEDURE IF EXISTS `ht_pagamento_cliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_pagamento_cliente`(in nome varchar(20), pag decimal(9,2))
begin
update tb_cliente
  set vl_gastos = vl_gastos - pag
    where nm_cliente = nome;
end $$

DELIMITER ;

--
-- Definition of procedure `ht_quarto_insert`
--

DROP PROCEDURE IF EXISTS `ht_quarto_insert`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ht_quarto_insert`(
cod_quarto varchar(20),
nomequarto varchar(20),
disponibilidade varchar(100),
situacao varchar(100),
categoria varchar(45))
begin
    if exists(select nm_quarto from tb_quarto where nm_quarto = nomequarto) then
      select concat('Quarto ',nomequarto,'não cadastrado pois o nome já existe') as Atenção;

    else

      insert into tb_quarto (cd_quarto, nm_quarto, ds_disponibilidade, ds_situacao, nm_categoria ) values (cod_quarto, nomequarto,disponibilidade,situacao,categoria);
            select concat('Quarto ', nomequarto, 'cadastrado com sucesso!') as informação;
                
   end if;
    end $$

DELIMITER ;

--
-- Definition of procedure `pp_quarto`
--

DROP PROCEDURE IF EXISTS `pp_quarto`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pp_quarto`()
begin
  select count(nm_quarto) from tb_quarto;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_cliente`
--

DROP PROCEDURE IF EXISTS `sp_cliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cliente`(nome varchar(100))
begin
        select nm_cliente, cd_cpf, vl_gastos, cd_cep, nm_cidade, cd_passaporte from tb_cliente where nm_cliente = nome;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_dados_cliente`
--

DROP PROCEDURE IF EXISTS `sp_dados_cliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_dados_cliente`(nome varchar(100))
begin
     --   select nm_cliente, cd_cpf, vl_gastos, cd_cep, nm_cidade, cd_passaporte from tb_cliente where nm_cliente = nome;

select tb_cliente.cd_cpf, tb_cliente.nm_cliente, tb_cliente.vl_gastos, tb_endereco.cd_cep, tb_cliente.cd_passaporte
        from tb_cliente inner join tb_endereco
          on tb_cliente.cd_cpf = tb_endereco.cd_cpf_cliente
             where nm_cliente = nome;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_insere_funcionario`
--

DROP PROCEDURE IF EXISTS `sp_insere_funcionario`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insere_funcionario`(in cpf varchar(20), nome varchar(45), login varchar(45), senha varchar(45),
                                          numero varchar(20), endereco varchar(100), cep varchar(10), cidade varchar(100), uf varchar(2), bairro varchar(100), cod_func varchar(20), pais varchar(45),
                                           cel varchar(20), tel varchar(20), email varchar(45), obs varchar(100), cod_func2 varchar(20))
begin
insert into tb_funcionario values (cpf, nome, login, senha);
  insert into tb_endereco (cd_endereco, nm_endereco, cd_cep, nm_cidade, sg_uf, nm_bairro, cd_cpf_func, nm_pais) values (numero, endereco, cep, cidade, uf, bairro, cod_func, pais);
  insert into tb_contato (cd_cel, cd_tel, nm_email, ds_obs_contato, cd_cpf_func) values (cel, tel, email, obs, cod_func2);
end $$

DELIMITER ;

--
-- Definition of procedure `sp_insere_produto`
--

DROP PROCEDURE IF EXISTS `sp_insere_produto`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insere_produto`(cod_produto varchar(100), nome varchar(60), valor decimal(9,2))
begin
    if exists(select cd_produto from tb_menu where cd_produto = cod_produto) then
      select concat('Produto ',nome,' não cadastrado pois o codigo ', cod_produto,' já existe') as Atenção;
    else
        insert into tb_menu(cd_produto, nm_produto, vl_produto) values (cod_produto, nome, valor);
          select concat('Produto ', nome, ' cadastrado com sucesso!') as Informação;
    end if;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_mostraNome`
--

DROP PROCEDURE IF EXISTS `sp_mostraNome`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_mostraNome`()
begin
select nm_funcionario from tb_funcionario;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_mostraNomeCliente`
--

DROP PROCEDURE IF EXISTS `sp_mostraNomeCliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_mostraNomeCliente`()
begin
select nm_cliente from tb_cliente;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_PagamentoNomeCliente`
--

DROP PROCEDURE IF EXISTS `sp_PagamentoNomeCliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_PagamentoNomeCliente`()
begin
select nm_cliente, vl_gastos from tb_cliente;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_reserva2`
--

DROP PROCEDURE IF EXISTS `sp_reserva2`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_reserva2`(in cpf varchar(20), nome varchar(45), nascimento date, passaporte varchar(20), nacionalidade varchar(45), gastos decimal(9,2),
                                cel varchar(20), tel varchar(20), email varchar(45), cliente varchar(20),
                              numero varchar(20), endereco varchar(100), cep varchar(10), cidade varchar(100), uf varchar(2), bairro varchar(100), cod_cliente varchar(20), pais varchar(45),
                              codigo varchar(100), dt_checkin date, dt_checkout date, hr_checkin time, hr_checkout time, hospedes varchar(45), obs varchar(100), valor decimal(9,2), cpf_cliente varchar(20))
begin
if (select cd_cpf from tb_cliente where cd_cpf = cpf) then
select concat('Este CPF já foi cadastrado!') as Msg3;
else
insert into tb_cliente (cd_cpf, nm_cliente, dt_nascimento, cd_passaporte, nm_nacionalidade, vl_gastos) values (cpf, nome, nascimento, passaporte, nacionalidade, gastos);
if (select cd_cel from tb_contato where cd_cel = cel) then
select concat('Esse número de celular já foi cadastrado!') as Msg1;
else
insert into tb_contato (cd_cel, cd_tel, nm_email, cd_cpf_cliente) values (cel, tel, email, cliente);
if (select cd_cep from tb_endereco where cd_cep = numero) then
select concat('Esse endereço já foi cadastrado!') as Msg2;
else
insert into tb_endereco (cd_endereco, nm_endereco, cd_cep, nm_cidade, sg_uf, nm_bairro, cd_cpf_cliente, nm_pais) values (numero, endereco, cep, cidade, uf, bairro, cod_cliente, pais);
insert into tb_reserva (cd_reserva, dt_check_in, dt_check_out, hr_check_in, hr_check_out, qt_hospede, ds_obs_reserva, vl_diaria, cd_cpf_cliente) values (codigo, dt_checkin, dt_checkout, hr_checkout, hr_checkin, hospedes, obs, valor, cpf_cliente);
end if;
end if;
end if;
end $$

DELIMITER ;

--
-- Definition of procedure `sp_reserva3`
--

DROP PROCEDURE IF EXISTS `sp_reserva3`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_reserva3`(in cpf varchar(20), nome varchar(45), nascimento date, passaporte varchar(20), nacionalidade varchar(45), gastos decimal(9,2),
                                cel varchar(20), tel varchar(20), email varchar(45), cliente varchar(20),
                              numero varchar(20), endereco varchar(100), cep varchar(10), cidade varchar(100), uf varchar(2), bairro varchar(100), cod_cliente varchar(20), pais varchar(45),
                              codigo varchar(100), dt_checkin date, dt_checkout date, hr_checkin time, hr_checkout time, hospedes varchar(45), obs varchar(100), valor decimal(9,2), cpf_cliente varchar(20),CodQuarto int)
begin
if (select cd_cpf from tb_cliente where cd_cpf = cpf) then
select concat('Este CPF já foi cadastrado!') as Msg3;
else
insert into tb_cliente (cd_cpf, nm_cliente, dt_nascimento, cd_passaporte, nm_nacionalidade, vl_gastos) values (cpf, nome, nascimento, passaporte, nacionalidade, gastos);
if (select cd_cel from tb_contato where cd_cel = cel) then
select concat('Esse número de celular já foi cadastrado!') as Msg1;
else
insert into tb_contato (cd_cel, cd_tel, nm_email, cd_cpf_cliente) values (cel, tel, email, cliente);
if (select cd_cep from tb_endereco where cd_cep = numero) then
select concat('Esse endereço já foi cadastrado!') as Msg2;
else
insert into tb_endereco (cd_endereco, nm_endereco, cd_cep, nm_cidade, sg_uf, nm_bairro, cd_cpf_cliente, nm_pais) values (numero, endereco, cep, cidade, uf, bairro, cod_cliente, pais);
insert into tb_reserva (cd_reserva, dt_check_in, dt_check_out, hr_check_in, hr_check_out, qt_hospede, ds_obs_reserva, vl_diaria, cd_cpf_cliente) values (codigo, dt_checkin, dt_checkout, hr_checkout, hr_checkin, hospedes, obs, valor, cpf_cliente);
update tb_quarto set cd_cpf_cliente = cpf where cd_quarto = CodQuarto;
update tb_quarto set cd_reserva = codigo  where cd_quarto = CodQuarto;
update tb_quarto set ds_disponibilidade = 'Ocupado' where cd_quarto = CodQuarto;
end if;
end if;
end if;
end $$

DELIMITER ;

--
-- Definition of procedure `valida_reserva`
--

DROP PROCEDURE IF EXISTS `valida_reserva`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `valida_reserva`(in cel varchar(20), cep varchar(20))
begin
if exists (select cd_cel from tb_contato where cd_cel = cel) then
select concat('Esse número de celular já foi cadastrado.') as Msg;
else
if exists (select cd_cep from tb_endereco where cd_cep = cep) then
select concat('Esse endereço já foi cadastrado.') as msg;
end if;
end if;
end $$

DELIMITER ;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

