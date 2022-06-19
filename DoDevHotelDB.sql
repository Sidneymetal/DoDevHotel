CREATE TABLE ht_hospede (
  id int PRIMARY KEY,
  nome varchar(256),
  telefone varchar(13),
  cpf varchar(13),
  email varchar(256),
  data_nascimento date,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp  
);

CREATE TABLE ht_servico (
  id int PRIMARY KEY,
  nome varchar(256),
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp
);

CREATE TABLE ht_hotel (
  id int PRIMARY KEY,
  nome varchar(256),  
  endereco varchar(256),
  cep varchar(8),
  descricao varchar(256),
  telefone varchar(13),
  email varchar(256),
  check_in date,
  check_out date,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp  
);

CREATE TABLE ht_quarto (
  id int PRIMARY KEY,
  id_hotel int, 
  id_tipo_quarto int,   
  numero int,
  andar int,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp 
);

CREATE TABLE ht_estadia (
  id int PRIMARY KEY,
  id_responsavel int, 
  id_quarto int, 
  data_entrada date,
  data_saida date,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp 
);

DROP TABLE ht_tipo_quarto (
  id int PRIMARY KEY,
  nome varchar(256),
  descricao varchar(256),
  ocupacao_maxima int,
  cama_casal int,
  cama_solteiro int,
  valor DECIMAL,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp
);

CREATE TABLE ht_estadia_x_hospede (
  id int PRIMARY KEY, 
  id_estadia int, 
  id_hospede int, 
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp  
);

CREATE TABLE ht_servico_x_hotel (
  id int PRIMARY KEY,
  id_hotel int, 
  id_estadia int, 
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp  
);

ALTER TABLE ht_estadia ADD FOREIGN KEY (id_responsavel) REFERENCES ht_hospede (id);
ALTER TABLE ht_estadia ADD FOREIGN KEY (id_quarto) REFERENCES ht_quarto (id);

ALTER TABLE ht_estadia_x_hospede ADD FOREIGN KEY (id_hospede) REFERENCES ht_hospede (id);
ALTER TABLE ht_estadia_x_hospede ADD FOREIGN KEY (id_estadia) REFERENCES ht_estadia (id);

ALTER TABLE ht_servico_x_hotel ADD FOREIGN KEY (id_estadia) REFERENCES ht_servico (id);
ALTER TABLE ht_servico_x_hotel ADD FOREIGN KEY (id_hotel) REFERENCES ht_hotel (id);

ALTER TABLE ht_quarto ADD FOREIGN KEY (id_hotel) REFERENCES ht_hotel (id);
ALTER TABLE ht_quarto ADD FOREIGN KEY (id_tipo_quarto) REFERENCES ht_tipo_quarto (id);

ALTER TABLE ht_hotel ALTER COLUMN check_in TYPE TIME(0)


SELECT * FROM ht_estadia