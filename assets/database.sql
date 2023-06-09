CREATE DATABASE IF NOT EXISTS jet_sale_pro;

USE jet_sale_pro;

CREATE TABLE IF NOT EXISTS produtos (
    codigo_produto INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    descricao VARCHAR(100) NOT NULL,
    codigo_barras INT(13) UNIQUE NOT NULL,
    marca VARCHAR(50) NOT NULL,
    peso FLOAT NOT NULL,
    largura FLOAT NOT NULL,
    altura FLOAT NOT NULL,
    profundidade FLOAT NOT NULL,
    situacao BOOLEAN NOT NULL,
    condicao VARCHAR(5) NOT NULL CHECK (condicao IN ('Novo', 'Usado')),
    preco_venda FLOAT NOT NULL,
    quantidade_estoque INT NOT NULL,
    data_cadastro DATE NOT NULL,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    atualizado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS clientes (
    codigo_cliente INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    nome VARCHAR(100) NOT NULL,
    situacao BOOLEAN NOT NULL,
    cpf VARCHAR(11) UNIQUE NOT NULL,
    rg VARCHAR(9) UNIQUE NOT NULL,
    genero INT(1) NOT NULL,
    data_nascimento DATE NOT NULL,
    estado_civil INT(1) NOT NULL,
    profissao VARCHAR(50),
    nacionalidade VARCHAR(50) NOT NULL,
    telefone INT(10) NOT NULL,
    celular INT(11) NOT NULL,
    whatsapp BOOLEAN NOT NULL,
    email VARCHAR(50),
    rua VARCHAR(50) NOT NULL,
    numero INT NOT NULL,
    complemento VARCHAR(50),
    bairro VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    uf VARCHAR(2) NOT NULL,
    cep INT(8) NOT NULL,
    observacoes VARCHAR(200) NOT NULL,
    data_cadastro DATE NOT NULL,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    atualizado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS vendas (
    codigo_venda INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    codigo_produto INT NOT NULL,
    codigo_cliente INT NOT NULL,
    data_venda DATE NOT NULL,
    total_itens INT NOT NULL,
    subtotal FLOAT NOT NULL,
    desconto FLOAT,
    valor_total FLOAT NOT NULL,
    forma_pagamento INT(1) NOT NULL,
    situacao INT(1) NOT NULL,
    observacoes VARCHAR(200),
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    atualizado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (codigo_produto) REFERENCES produtos (codigo_produto),
    FOREIGN KEY (codigo_cliente) REFERENCES clientes (codigo_cliente)
);

CREATE TABLE IF NOT EXISTS itens_venda (
    codigo_item_venda INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    codigo_venda INT NOT NULL,
    codigo_produto INT NOT NULL,
    quantidade INT NOT NULL CHECK (quantidade > 0),
    descricao VARCHAR(100) NOT NULL,
    valor_unitario FLOAT NOT NULL,
    subtotal_produto FLOAT NOT NULL,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    atualizado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (codigo_venda) REFERENCES vendas (codigo_venda),
    FOREIGN KEY (codigo_produto) REFERENCES produtos (codigo_produto)
);

CREATE TABLE IF NOT EXISTS usuarios (
    codigo_usuario INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(15) UNIQUE NOT NULL,
    senha VARCHAR(255) NOT NULL,
    situacao BOOLEAN NOT NULL,
    adm BOOLEAN NOT NULL DEFAULT FALSE,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    atualizado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

INSERT INTO usuarios (nome, usuario, senha, situacao, adm)
SELECT 'Master', 'master', '/GE7Tf1nNqe9JoyKDnTtDRwEqVn1nddO8odJg/1EP8k=', TRUE, TRUE
WHERE NOT EXISTS (
    SELECT 1 FROM usuarios WHERE usuario = 'master'
);
