USE jet_sale_pro;

-- Inserir dados na tabela 'produtos'
INSERT INTO produtos (descricao, codigo_barras, marca, peso, largura, altura, profundidade, situacao, condicao, preco_venda, quantidade_estoque)
VALUES
    ('Produto 1', 1234567890123, 'Marca A', 1.5, 10, 5, 3, TRUE, 'Novo', 10.99, 10),
    ('Produto 2', 2345678901234, 'Marca B', 2.0, 8, 6, 4, TRUE, 'Novo', 15.99, 20),
    ('Produto 3', 3456789012345, 'Marca C', 1.8, 12, 4, 6, TRUE, 'Novo', 8.99, 15),
    ('Produto 4', 4567890123456, 'Marca A', 1.2, 6, 7, 2, TRUE, 'Novo', 12.99, 5),
    ('Produto 5', 5678901234567, 'Marca B', 2.5, 9, 3, 5, TRUE, 'Novo', 19.99, 8);

-- Inserir dados na tabela 'clientes'
INSERT INTO clientes (nome, situacao, cpf, rg, genero, data_nascimento, estado_civil, profissao, nacionalidade, telefone, celular, whatsapp, email, rua, numero, complemento, bairro, cidade, uf, cep, observacoes)
VALUES
    ('Cliente 1', TRUE, '12345678901', '12345678', 'Masculino', '1990-01-01', 'Solteiro(a)', 'Professor', 'Brasileiro', 1234567890, 12345678901, TRUE, 'cliente1@email.com', 'Rua A', 1, 'Apto 101', 'Bairro A', 'Cidade A', 'UF', 12345678, 'Observações 1'),
    ('Cliente 2', TRUE, '23456789012', '23456789', 'Feminino', '1992-02-02', 'Casado(a)', 'Engenheiro', 'Brasileiro', 2345678901, 23456789012, TRUE, 'cliente2@email.com', 'Rua B', 2, 'Casa 202', 'Bairro B', 'Cidade B', 'UF', 23456789, 'Observações 2'),
    ('Cliente 3', TRUE, '34567890123', '34567890', 'Outro', '1995-03-03', 'Divorciado(a)', 'Médico', 'Brasileiro', 3456789012, 34567890123, TRUE, 'cliente3@email.com', 'Rua C', 3, 'Sala 303', 'Bairro C', 'Cidade C', 'UF', 34567890, 'Observações 3'),
    ('Cliente 4', TRUE, '45678901234', '45678901', 'Masculino', '1988-04-04', 'Divorciado(a)', 'Advogado', 'Brasileiro', 4567890123, 45678901234, TRUE, 'cliente4@email.com', 'Rua D', 4, NULL, 'Bairro D', 'Cidade D', 'UF', 45678901, 'Observações 4'),
    ('Cliente 5', TRUE, '56789012345', '56789012', 'Masculino', '1993-05-05', 'Viúvo(a)', 'Estudante', 'Brasileiro', 5678901234, 56789012345, TRUE, NULL, 'Rua E', 5, 'Bloco 505', 'Bairro E', 'Cidade E', 'UF', 56789012, 'Observações 5');

-- Inserir dados na tabela 'vendas'
INSERT INTO vendas (codigo_produto, codigo_cliente, data_venda, total_itens, subtotal, desconto, valor_total, forma_pagamento, situacao, observacoes)
VALUES
    (1, 1, '2023-06-01', 2, 21.98, 1.99, 19.99, 1, 1, 'Observações venda 1'),
    (2, 2, '2023-06-02', 3, 47.97, 2.0, 45.97, 2, 1, 'Observações venda 2'),
    (3, 3, '2023-06-03', 1, 8.99, NULL, 8.99, 1, 1, NULL),
    (4, 4, '2023-06-04', 4, 51.96, 4.0, 47.96, 1, 1, 'Observações venda 4'),
    (5, 5, '2023-06-05', 2, 39.98, NULL, 39.98, 3, 1, 'Observações venda 5');

-- Inserir dados na tabela 'itens_venda'
INSERT INTO itens_venda (codigo_venda, codigo_produto, quantidade, descricao, valor_unitario, subtotal_produto)
VALUES
    (1, 1, 1, 'Produto 1', 10.99, 10.99),
    (1, 3, 1, 'Produto 3', 8.99, 8.99),
    (2, 2, 2, 'Produto 2', 15.99, 31.98),
    (2, 4, 1, 'Produto 4', 12.99, 12.99),
    (2, 5, 1, 'Produto 5', 19.99, 19.99);
