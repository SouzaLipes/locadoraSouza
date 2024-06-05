CREATE TABLE Cliente (
    IdCliente INT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    CPF VARCHAR(11) UNIQUE NOT NULL,
    Endereco VARCHAR(255),
    Telefone VARCHAR(15),
    Email VARCHAR(100) UNIQUE
);

CREATE TABLE MarcaVeiculo (
    IdMarca INT PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL
);

CREATE TABLE CategoriaVeiculo (
    IdCategoriaVeiculo INT PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL
);

CREATE TABLE ModeloVeiculo (
    IdModelo INT PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    IdMarca INT,
    IdCategoriaVeiculo INT,
    FOREIGN KEY (IdMarca) REFERENCES MarcaVeiculo(IdMarca),
    FOREIGN KEY (IdCategoriaVeiculo) REFERENCES CategoriaVeiculo(IdCategoriaVeiculo)
);

CREATE TABLE Veiculo (
    IdVeiculo INT PRIMARY KEY,
    Placa VARCHAR(10) UNIQUE NOT NULL,
    Ano INT NOT NULL,
    Cor VARCHAR(30),
    IdModelo INT,
    PrecoDiario DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (IdModelo) REFERENCES ModeloVeiculo(IdModelo)
);

CREATE TABLE Reserva (
    IdReserva INT PRIMARY KEY,
    DataInicio DATE NOT NULL,
    DataFim DATE NOT NULL,
    IdCliente INT,
    IdVeiculo INT,
    ValorTotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente),
    FOREIGN KEY (IdVeiculo) REFERENCES Veiculo(IdVeiculo)
);

CREATE TABLE Pagamento (
    IdPagamento INT PRIMARY KEY,
    IdReserva INT,
    DataPagamento DATE NOT NULL,
    Valor DECIMAL(10, 2) NOT NULL,
    MetodoPagamento VARCHAR(50) NOT NULL,
    FOREIGN KEY (IdReserva) REFERENCES Reserva(IdReserva)
);
