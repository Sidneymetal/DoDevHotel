CREATE TABLE ht_hospede (
  id [pk],
  nome varchar(256),
  telefone varchar(13),
  cpf varchar(13),
  email varchar(256),
  data_nascimento date,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp  
);

CREATE TABLE ht_servico (
  id [pk],
  nome varchar(256),
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp
);

CREATE TABLE ht_hotel (
  id [pk],
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
  id [pk],
  numero integer,
  andar integer,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp,
  id_tipo_quarto [fk],
  id_hotel[fk]
);

CREATE TABLE ht_estadia (
  id [pk],
  id_responsavel [fk],
  id_quarto [fk],
  data_entrada date,
  data_saida date,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp 
);

CREATE TABLE ht_tipos_quarto (
  id [pk],
  nome varchar(256),
  descricao varchar(256),
  ocupacao_maxima integer,
  cama_casal integer,
  cama_solteiro integer,
  valor decimal,
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp
);

CREATE TABLE ht_estadia_x_hospede (
  id [pk], 
  id_hotel [fk],
  id_estadia [fk], 
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp  
);

CREATE TABLE ht_servico_x_hotel (
  id [pk], 
  id_hotel [fk],
  id_estadia [fk], 
  data_cadastro timestamp,
  data_ultima_atualizacao timestamp  
);

ALTER TABLE ht_estadia ADD FOREIGN KEY (id_responsavel) REFERENCES ht_hotel (id);

ALTER TABLE ht_estadia ADD FOREIGN KEY (id_quarto) REFERENCES ht_hospede (id);

ALTER TABLE ht_hotel ADD FOREIGN KEY (id_quarto) REFERENCES ht_quarto (id);

ALTER TABLE ht_quarto ADD FOREIGN KEY (id_tipo_quarto) REFERENCES ht_tipos_quarto (id);

ALTER TABLE ht_hospede ADD FOREIGN KEY (id_servico) REFERENCES ht_servico (id);
