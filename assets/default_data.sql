USE jet_sale_pro;

-- Inserir dados na tabela 'produtos'
INSERT INTO produtos (descricao, codigo_barras, marca, peso, largura, altura, profundidade, situacao, condicao, preco_venda, quantidade_estoque)
VALUES
  ('Smartphone Samsung Galaxy S20', 8806090276153, 'Samsung', 163, 75, 159, 8, TRUE, 'Novo', 1499.00, 50),
  ('Notebook Dell XPS 13', 884116343466, 'Dell', 1200, 29.2, 19.9, 1.46, TRUE, 'Novo', 2400.99, 25),
  ('TV LG OLED55C9', 8806098381585, 'LG', 18600, 122.8, 70.8, 24.1, TRUE, 'Novo', 1255.15, 15),
  ('Fone de Ouvido Sony', 2724292389726, 'Sony', 254, 18, 25.2, 5.4, TRUE, 'Novo', 35.10, 30),
  ('Câmera Canon EOS', 013803286643, 'Canon', 532, 13.2, 10.1, 7.6, TRUE, 'Novo', 123.90, 12);

-- Inserir dados na tabela 'clientes'
INSERT INTO clientes (nome, situacao, cpf, rg, genero, data_nascimento, estado_civil, profissao, nacionalidade, telefone, celular, whatsapp, email, rua, numero, complemento, bairro, cidade, uf, cep, observacoes)
VALUES
  ('João Silva', TRUE, '12510619071', '294162549', 'Masculino', '1985-07-12', 'Solteiro(a)', 'Engenheiro', 'Brasileiro', 8429308318, 17993732928, TRUE, 'joao.sil@gmail.com', 'Rua das Flores', 13, NULL, 'Centro', 'São Paulo', 'SP', '01234567', NULL),
  ('Maria Santos', TRUE, '76694472064', '504969638', 'Feminino', '1990-03-25', 'Casado(a)', 'Advogada', 'Brasileira', 6126925560, 71984747126, TRUE, 'maria01@gmail.com', 'Avenida do Sol', 51, 'Apto 101', 'Jardim das Palmeiras', 'Campinas', 'SP', '12345678', 'Cliente preferencial'),
  ('Pedro Oliveira', TRUE, '17039611023', '128198254', 'Masculino', '1988-11-15', 'Casado(a)', 'Médico', 'Brasileiro', 1735727070, 95985347655, FALSE, 'pedro.oliveira@hotmail.com', 'Rua dos Passarinhos', 78, NULL, 'Vila das Flores', 'Rio de Janeiro', 'RJ', '23456789', 'Cliente há 5 anos'),
  ('Camila Almeida', TRUE, '76795371867', '136979592', 'Feminino', '1995-09-03', 'Solteiro(a)', 'Arquiteta', 'Brasileira', 9137894821, 87992493429, TRUE, 'camila.almeida@gmail.com', 'Avenida das Árvores', 101, NULL, 'Jardim Botânico', 'Brasília', 'DF', '34567890', NULL),
  ('Carlos Pereira', FALSE, '09834789882', '498159127', 'Masculino', '1992-06-18', 'Viúvo(a)', 'Empresário', 'Brasileiro', 8426175642, 84991575994, TRUE, 'carlos@pereira.com', 'Rua das Pedras', 22, 'Bloco 505', 'Praia da Barra', 'Rio de Janeiro', 'RJ', '45678901', 'Cliente frequente em eventos de networking');

-- Inserir dados na tabela 'vendas'
INSERT INTO vendas (codigo_cliente, codigo_usuario, data_venda, total_itens, subtotal, desconto, valor_total, forma_pagamento, situacao, observacoes)
VALUES
    (1, 1, '2023-06-01', 2, 70.20, 11.99, 58.21, 'Depósito Bancário', 'Aberta', 'Observações venda 1'),
    (2, 2, '2023-06-02', 3, 1414.15, 72.0, 1342.15, 'Cartão Crédito', 'Aberta', NULL),
    (3, 2, '2023-06-03', 1, 2400.99, NULL, 2400.99, 'Cartão Débito', 'Paga', NULL),
    (4, 1, '2023-06-04', 1, 35.10, 4.0, 31.10, 'Pix', 'Paga', 'Observações venda 4'),
    (4, 2, '2023-06-05', 1, 123.90, NULL, 123.90, 'Dinheiro', 'Entregue', 'Observações venda 5');

-- Inserir dados na tabela 'itens_venda'
INSERT INTO itens_venda (codigo_venda, codigo_produto, quantidade, descricao, valor_unitario, subtotal_produto)
VALUES
    (1, 4, 2, 'Fone de Ouvido Sony', 35.10, 35.10),
    (2, 3, 1, 'TV LG OLED55C9', 1255.15, 1255.15),
    (2, 4, 1, 'Fone de Ouvido Sony', 35.10, 35.10),
    (2, 5, 1, 'Câmera Canon EOS', 123.90, 123.90),
    (3, 2, 1, 'Notebook Dell XPS 13', 2400.99, 2400.99),
    (4, 4, 1, 'Fone de Ouvido Sony', 35.10, 35.10),
    (5, 5, 1, 'Câmera Canon EOS', 123.90, 123.90);