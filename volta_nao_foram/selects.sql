
-- Faça uma consulta em sql que retorne somente a placa do veículo, nome, cpf e idade do motorista utilizado na viagem com id 2.

SELECT Nome,Cpf,Idade,Placa FROM `Motorista`,Veiculo,Viagem WHERE Viagem.ViagemID = 2 and Viagem.MotoristaID = Motorista.MotoristaId and Viagem.VeiculoID = Veiculo.VeiculoId;

-- Faça uma consulta em sql que retorne somente o nome e o cpf dos motoristasutilizados em todas as viagens ordenado pelo nome.

SELECT DISTINCT nome,cpf FROM Motorista, Viagem WHERE Motorista.MotoristaId = Viagem.MotoristaID order by nome;

-- Ou

SELECT DISTINCT nome,cpf FROM `Motorista`WHERE Motorista.MotoristaId in (SELECT MotoristaId from Viagem) order by nome;


-- Faça uma consulta em sql que retorne somente o nome dos motoristas que realizaram viagens em veículos de cor iniciada em “V”

SELECT DISTINCT nome FROM Motorista, Viagem, Veiculo WHERE Motorista.MotoristaId = Viagem.MotoristaID and Viagem.VeiculoID = Veiculo.VeiculoId and Veiculo.Cor like "V%";

