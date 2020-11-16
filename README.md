# Sistema de Clientes
![](/Screen.jpg)
###### Clique [aqui](https://drive.google.com/drive/folders/1jJW8Y2eKRQIDudEy8SDALr6CIQFTLN6i?usp=sharing) para ver todos screenshots.
### Programa de gerenciamento de clientes que utiliza o banco de dados MySQL.
#### Armazena dados como:
- Nome
- CPF
- Email
- Telefone
- Data de nascimento
- Endereço completo
#### É possível Criar, Atualizar e Excluir clientes.
#### A aba Consultar oferece a opção de buscar clientes pelo nome ou ID, e também a opção de mostrar todos.
#### A opção Abrir abre uma nova janela maior com os resultados da busca, e possui a opção Criar PDF que gera um PDF na pasta C://, e a opção Abrir no Excel que abre o Excel com os resultados da busca. .
#### Aplicação em C# e Windows Forms feita no Visual Studio 2019.

#### Comandos no MySql para criar a tabela compativel com o programa.
##### Criar banco de dados.
###### CREATE DATABASE SISTEMADECLIENTES;
##### Usar o banco criado.
###### USE SISTEMADECLIENTES;
##### Criar tabela.
###### CREATE TABLE CLIENTES ( ID INT (4) NOT NULL AUTO_INCREMENT,	NOME VARCHAR(60) NOT NULL, EMAIL VARCHAR(100), TELEFONE VARCHAR(15), DATA VARCHAR(10), CPF VARCHAR(15), CEP VARCHAR(10), RUA VARCHAR(60),	NUMERO INT(5), UF CHAR(2), CIDADE VARCHAR(20), BAIRRO VARCHAR(20), PRIMARY KEY (ID));
##### Na classe MySqlParametros.cs é colocado os dados de conexão para acessar o banco.

